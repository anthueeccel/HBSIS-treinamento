using LocacaoBiblioteca.Model;
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

        private LocacaoContext contextDB = new LocacaoContext();

        /// <summary>
        /// Método que valida Login e Senha no sistema
        /// Para realizar o login padrão usasse:
        /// - login: admin
        /// - senha: admin
        /// </summary>
        /// <param name="Usuario">passamos um objeto Usuario</param>
        /// <returns>Verdadeiro quando existir usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return contextDB.ListaDeUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);

            //for (int i = 0; i < list.Count; i++)
            //{                
            //    if (usuarios.Login.Equals(list[i].Login) && usuarios.Senha.Equals(list[i].Senha))
            //        return true;
            //}
            //return false;
        }



        /// <summary>
        /// Método que retorna a lista de usuários
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ListaUsuarios(Usuario usuario)
        {
            if (usuario.Id.Equals(0))
            {
                return contextDB.ListaDeUsuarios.Where(x => x.Ativo == true).ToList<Usuario>();
            }
            else
            {
                List<Usuario> ListaUsuarioUnico = new List<Usuario>();
                contextDB.ListaDeUsuarios.ForEach(x =>
                {
                    if (x.Id == usuario.Id)
                        ListaUsuarioUnico.Add(usuario);
                });
                return contextDB.ListaDeUsuarios = ListaUsuarioUnico;
            }
        }

        /// <summary>
        /// Método que adiciona usuários a lista de usuários.
        /// </summary>
        /// <param name="usuario"></param>
        public void AdicionaUsuario(Usuario usuario)
        {
            usuario.Id = contextDB.idContadorUsuario++;
            contextDB.ListaDeUsuarios.Add(usuario);
        }

        /// <summary>
        /// Excluí usuário do sistema
        /// </summary>
        /// <param name="usuario"></param>
        public void RemoverUsuarioPorId(int id)
        {
            var usuario = contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == id);
            if (usuario != null)
                usuario.Ativo = false;
        }


    }
}
