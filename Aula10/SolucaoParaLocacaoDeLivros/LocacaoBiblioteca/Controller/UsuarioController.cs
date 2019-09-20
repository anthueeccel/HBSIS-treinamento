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

        // Declaração da lista
        public List<Usuario> ListaDeUsuarios { get; set; }
        


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
        public List<Usuario> ListaUsuarios()
        {
            return ListaDeUsuarios;
        }
        
        public void AdicionaUsuario()
        {
            Usuario usuario = new Usuario();

            Console.Write("Informe o Login: ");
            usuario.Login = Console.ReadLine();
            Console.Write("Informe a Senha: ");
            usuario.Senha = Console.ReadLine();

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = ListaDeUsuarios.Count + 1,
                Login = usuario.Login,
                Senha = usuario.Senha,
                Ativo = true
            });
            Console.WriteLine($"Usuário {ListaDeUsuarios[ListaDeUsuarios.Count - 1].Login} adicionado com sucesso. ID: {ListaDeUsuarios[ListaDeUsuarios.Count - 1].Id} ");
        }

        public void PopulaListaUsuario()
        {
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = 001,
                Login = "admin",
                Senha = "admin",
                Ativo = true
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = 002,
                Login = "anthue",
                Senha = "1234",
                Ativo = true
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = 003,
                Login = "usuario1",
                Senha = "1234",
                Ativo = true
            });
        }

    }
}
