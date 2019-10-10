using LocacaoBiblioteca.Model;
using LocacaoBiblioteca.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os métodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        /// <summary>
        /// Contrutor da Classe Usuario
        /// </summary>
        public UsuarioController()
        {

        }

        private LocacaoContext contextDb = new LocacaoContext();

        /// <summary>
        /// Método que valida Login e Senha no sistema
        /// Para realizar o login padrão usasse:
        /// - login: admin
        /// - senha: admin
        /// </summary>
        /// <param name="Usuario">passamos um objeto Usuario</param>
        /// <returns>Verdadeiro quando existir usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuario)
        {
            var Md5Pass = EncryptMD5.MD5Hash(usuario.Senha);
            var result = contextDb.Usuarios.FirstOrDefault(x => x.Login == usuario.Login && x.Senha == Md5Pass);
            if (result != null)
                return true;
            else
                return false;
        }
        

        /// <summary>
        /// Métoo que retorna a lista dos usuários
        /// </summary>
        /// <returns></returns>
        public IQueryable<Usuario> GetUsuarios()
        {
            return contextDb.Usuarios.Where(x => x.Ativo == true);
        }
               
        /// <summary>
        /// Método que retorna os usuários do sistema
        /// </summary>
        /// <returns></returns>
        public Usuario GetUsuarios(Usuario usuario)
        {
                var ususario = contextDb.Usuarios.SingleOrDefault(x => x.Id == usuario.Id);
            return usuario;
        }

        /// <summary>
        /// Método que adiciona usuários a lista de usuários.
        /// </summary>
        /// <param name="usuario"></param>
        public void AddUsuario(Usuario usuario)
        {
            contextDb.Usuarios.Add(usuario);
            contextDb.SaveChanges();
        }

        /// <summary>
        /// Excluí usuário do sistema
        /// </summary>
        /// <param name="usuario"></param>
        public void RemoverUsuarioPorId(int id)
        {
            var usuario = contextDb.Usuarios.FirstOrDefault(x => x.Id == id);
            if (usuario != null)
                usuario.Ativo = false;
            contextDb.SaveChanges();
        }

        /// <summary>
        /// Método que atualiza os dados de um Usuario do sistema
        /// </summary>
        /// <param name="usuarioUpdate">Dados atualizados</param>
        /// <returns>Verdadeiro (atualizado) ou Falso (não atualizado)</returns>
        public bool UpdateUsuario(Usuario usuarioUpdate)
        {

            var result = contextDb.Usuarios.FirstOrDefault(b => b.Id == usuarioUpdate.Id);
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
