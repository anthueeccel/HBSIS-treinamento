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
        static Usuario usuario = new Usuario();

        static void Main(string[] args)
        {
            livrosController.PopulaListaLivros();
            usuariosController.PopulaListaUsuarios();
            //TelaDeLogin();

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
                Console.WriteLine("3 - Excluir Usuario");
                Console.WriteLine("4 - Listar livros");
                Console.WriteLine("5 - Cadastra Livro");
                Console.WriteLine("9 - Trocar Usuário");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        ListaUsuario(usuario);
                        Console.ReadKey();
                        break;
                    case 2:
                        CadastraUsuario();
                        Console.ReadKey();
                        break;
                    case 3:
                        ExcluiUsuarioPorId();
                        Console.ReadKey();
                        break;
                    case 4:
                        ListaLivro();
                        Console.ReadKey();
                        break;
                    case 5:
                        CadastraLivro();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        TelaDeLogin();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Método para exluir usuário através do seu Id
        /// </summary>
        private static void ExcluiUsuarioPorId()
        {
            ListaUsuario(usuario);
            Console.WriteLine("Informe o ID: ");
            int id = int.Parse(Console.ReadLine());
            usuariosController.ListaUsuarios(usuario);
            Console.Write("Confirma desativar este usuário? (S/N)");
            var confirmaExclusao = Console.ReadKey().KeyChar.ToString().ToLower();
            if (confirmaExclusao == "s")
                usuariosController.RemoverUsuarioPorId(id);
        }

        /// <summary>
        /// Método que cadastra um livro no sistema
        /// </summary>
        private static void CadastraLivro()
        {
            Console.WriteLine("Cadastrar livro no sistema");
            Console.Write("Informe  o nome do livro: ");
            var nome = Console.ReadLine();

            livrosController.AdicionaLivro(new Livro()
            {
                Nome = nome,
                Ativo = true

            });
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        /// <summary>
        /// Método que lista os usuários cadastrados no sistema
        /// </summary>
        private static void ListaUsuario(Usuario usuario)
        {
           var listaDeUsuarios = usuariosController.ListaUsuarios(usuario);
            Console.WriteLine("Lista de usuários:");
            listaDeUsuarios.ForEach(s => Console.WriteLine($"ID: {s.Id} NOME: {s.Login} SENHA: ****** ATIVO: {s.Ativo.ToString()}"));

        }


        /// <summary>
        /// Método que cadastra usuário no sistema
        /// </summary>
        private static void CadastraUsuario()
        {
            Usuario usuario = new Usuario();

            Console.Write("Informe o Login: ");
            usuario.Login = Console.ReadLine();
            Console.Write("Informe a Senha: ");
            usuario.Senha = Console.ReadLine();

            new Usuario()
            {
                Login = usuario.Login,
                Senha = usuario.Senha,
                Ativo = true
            };

            //Console.WriteLine($"Usuário {ListaDeUsuarios[ListaDeUsuarios.Count - 1].Login} adicionado com sucesso. ID: {ListaDeUsuarios[ListaDeUsuarios.Count - 1].Id} ");
            usuariosController.AdicionaUsuario(usuario);
            Console.WriteLine("Usuário cadastrado com sucesso! (Press any key...)");

        }

        /// <summary>
        /// Método que lista livros cdastrados no sistema
        /// </summary>               
        private static void ListaLivro()
        {
            var list = livrosController.ListarLivros();
            Console.WriteLine("Lista de livros disponíveis:");
            list.ForEach(x => Console.WriteLine($"ID: {x.Id}| ATIVO: {x.Ativo.ToString()}| NOME: {x.Nome}"));
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

