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
        //Criado privado para impedir o programador de adicionar um ID ou alterar fora da classe
        private int idContador = 0;

        /// <summary>
        /// Contrutor da Classe Usuario
        /// </summary>
        public UsuarioController()
        {           

        }

        // Declaração da lista
        private List<Usuario> ListaDeUsuarios { get; set; }



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
            return ListaDeUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);

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
                return ListaDeUsuarios.Where(x => x.Ativo == true).ToList<Usuario>();                
            }
            else
            {
                List<Usuario> ListaUsuarioUnico = new List<Usuario>();
                ListaDeUsuarios.ForEach(x =>
                {
                    if (x.Id == usuario.Id)
                        ListaUsuarioUnico.Add(usuario);
                });
                return ListaDeUsuarios = ListaUsuarioUnico;
            }
        }

        /// <summary>
        /// Método que adiciona usuários a lista de usuários.
        /// </summary>
        /// <param name="usuario"></param>
        public void AdicionaUsuario(Usuario usuario)
        {
            usuario.Id = idContador++;
            ListaDeUsuarios.Add(usuario);
        }

        /// <summary>
        /// Método para popular/adicionar uma lista de usuários pré-definida ao sistema
        /// </summary>
       

        /// <summary>
        /// Excluí usuário do sistema
        /// </summary>
        /// <param name="usuario"></param>
        public void RemoverUsuarioPorId(int id)
        {
            ListaDeUsuarios.FirstOrDefault(x => x.Id == id).Ativo = false;                       
        }

        public void PopulaListaUsuarios()
        {
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = ++idContador,
                Login = "admin",
                Senha = "admin",
                Ativo = true
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = ++idContador,
                Login = "anthue",
                Senha = "1234",
                Ativo = true
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = ++idContador,
                Login = "usuario1",
                Senha = "1234",
                Ativo = true
            });
        }
    }
}
