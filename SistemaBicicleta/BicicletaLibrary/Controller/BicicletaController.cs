using BicicletaLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Controller
{
    class BicicletaController
    {
        private BicicletaContext contextDb = new BicicletaContext();

                
        /// <summary>
        /// Métoo que retorna a lista dos usuários
        /// </summary>
        /// <returns></returns>
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contextDb.Bicicletas.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Método que retorna os usuários do sistema
        /// </summary>
        /// <returns></returns>
        public Bicicleta GetUsuarios(Bicicleta usuario)
        {
            var ususario = contextDb.Bicicletas.SingleOrDefault(x => x.Id == usuario.Id);
            return usuario;
        }

        /// <summary>
        /// Método que adiciona usuários a lista de usuários.
        /// </summary>
        /// <param name="usuario"></param>
        public void AddUsuario(Bicicleta usuario)
        {
            contextDb.Bicicletas.Add(usuario);
            contextDb.SaveChanges();
        }

        /// <summary>
        /// Excluí usuário do sistema
        /// </summary>
        /// <param name="usuario"></param>
        public void RemoverUsuarioPorId(int id)
        {
            var usuario = contextDb.Bicicletas.FirstOrDefault(x => x.Id == id);
            if (usuario != null)
                usuario.Ativo = false;
            contextDb.SaveChanges();
        }

        /// <summary>
        /// Método que atualiza os dados de um Usuario do sistema
        /// </summary>
        /// <param name="usuarioUpdate">Dados atualizados</param>
        /// <returns>Verdadeiro (atualizado) ou Falso (não atualizado)</returns>
        public bool UpdateUsuario(Bicicleta usuarioUpdate)
        {

            var result = contextDb.Bicicletas.FirstOrDefault(b => b.Id == usuarioUpdate.Id);
            if (result != null)
            {
                result.Id = usuarioUpdate.Id;
                result.Login = usuarioUpdate.Login;
                result.Senha = EncryptMD5.MD5Hash(usuarioUpdate.Senha);
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;

        }

    }
}
