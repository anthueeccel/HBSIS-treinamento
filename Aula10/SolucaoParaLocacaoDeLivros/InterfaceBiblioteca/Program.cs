using System;
using LocacaoBiblioteca.Controller;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivroController livrosController = new LivroController();
        static UsuarioController usuariosController = new UsuarioController();
        
        static void Main(string[] args)
        {
            usuariosController.PopulaListaUsuario();

            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            TelaDeLogin();

            MostraMenuSistema();

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra o Menu inicial do sistema (console)
        /// </summary>
        private static void MostraMenuSistema()
        {
            int opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Cadastra Usuario");
                Console.WriteLine("3 - Livros");
                Console.WriteLine("4 - Cadastra Livro");
                Console.WriteLine("5 - Trocar Usuário");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        ListaUsuario();
                        Console.ReadKey();
                        break;
                    case 2:
                        CadastraUsuario();
                        Console.ReadKey();
                        break;
                    case 3:
                        ListaLivro();
                        Console.ReadKey();
                        break;
                    case 4:
                        CadastraLivro();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        TelaDeLogin();                        
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Método que cadastra um livro no sistema
        /// </summary>
        private static void CadastraLivro()
        {
            livrosController.AdicionaLivro();
        }

        /// <summary>
        /// Método que lista os usuários cadastrados no sistema
        /// </summary>
        private static void ListaUsuario()
        {
            Console.WriteLine("Lista de livros disponíveis:");
            usuariosController.ListaUsuarios().ForEach(x => Console.WriteLine($"ID: {x.Id} NOME: {x.Login} SENHA: ****** ATIVO: {x.Ativo.ToString()}"));
        }

        /// <summary>
        /// Método que cadastra usuário no sistema
        /// </summary>
        private static void CadastraUsuario()
        {
            usuariosController.AdicionaUsuario();
        }

        /// <summary>
        /// Método que lista livros cdastrados no sistema
        /// </summary>               
        private static void ListaLivro()
        {
            var list = livrosController.ListarLivros();
            Console.WriteLine("Lista de livros disponíveis:");
            list.ForEach(x => Console.WriteLine($"ID: {x.Id} NOME: {x.Nome} ATIVO: {x.Ativo.ToString()}"));
        }

        /// <summary>
        /// Tela de login (console) do sistema para validar login e senha para acessar o sistema
        /// </summary>
        /// <returns>Login e senha = verdadeiro ou falso</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema: ");

            Console.Write("Login: ");
            var loginDoUsuario = Console.ReadLine();
            Console.Write("Senha: ");
            var senhaDoUsuario = Console.ReadLine();


            return usuariosController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });
        }

        /// <summary>
        /// Tela inicial de Login
        /// </summary>
        private static void TelaDeLogin()
        {
            while (!RealizaLoginSistema())
                Console.WriteLine("Login ou senha inválidos");
        }
    }
}

