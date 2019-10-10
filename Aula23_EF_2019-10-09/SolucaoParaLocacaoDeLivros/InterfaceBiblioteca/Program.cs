using System;
using LocacaoBiblioteca.Controller;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LocacaoBiblioteca.Model;
using LocacaoBiblioteca.Utils;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivroController livrosController = new LivroController();
        static UsuarioController usuariosController = new UsuarioController();
        static Usuario usuario = new Usuario();
        static Livro livro = new Livro();
        static Usuario logedin = null;

        #region Método Main
        static void Main(string[] args)
        {

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
            while (opcao != 99)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 2.0.1");
                Console.WriteLine($"Não é {logedin.Login.ToUpper()}? Pressione 9.");
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Cadastra Usuario");
                Console.WriteLine("3 - Excluir Usuario");
                Console.WriteLine("4 - Editar Usuario");
                Console.WriteLine("5 - Listar livros");
                Console.WriteLine("6 - Cadastra Livro");
                Console.WriteLine("7 - Excluir Livro");
                Console.WriteLine("8 - Editar Livro");
                Console.WriteLine("9 - Trocar Usuário");
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
                        ExcluiUsuarioPorId();
                        Console.ReadKey();
                        break;
                    case 4:
                        AtualizaUsuario();
                        Console.ReadKey();
                        break;
                    case 5:
                        ListaLivros();
                        Console.ReadKey();
                        break;
                    case 6:
                        CadastraLivro();
                        Console.ReadKey();
                        break;
                    case 7:
                        ExcluiLivroPorId();
                        Console.ReadKey();
                        break;
                    case 8:
                        AtualizaLivro();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        TelaDeLogin();
                        break;
                    case 0:
                        Console.Write("\nEncerrando sistema");
                        opcao = 99;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        private static void AtualizaUsuario()
        {
            ListaUsuario();
            Console.Write("Informe o ID para atualizar: ");
            usuario.Id = int.Parse(Console.ReadLine());
            var livro = usuariosController.GetUsuarios().ToList()
              .SingleOrDefault(x => x.Id == usuario.Id);
            Console.Write("Login: ");
            usuario.Login = Console.ReadLine();
            Console.Write("Senha: ");
            usuario.Senha = Console.ReadLine();
            if (usuariosController.UpdateUsuario(usuario))
                Console.WriteLine("Usuario Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao salvar alteração");
        }

        private static void AtualizaLivro()
        {

            ListaLivros();
            Console.Write("Informe o ID para atualizar: ");
            int id = int.Parse(Console.ReadLine());
            var livro = livrosController.GetLivros().ToList()
                .SingleOrDefault(x => x.Id == id);
            Console.Write("Nome: ");
            livro.Nome = Console.ReadLine();
            if (livrosController.UpdateLivro(livro))
                Console.WriteLine("Livro Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao salvar alteração");

        }

        /// <summary>
        /// Método para exluir usuário através do seu Id
        /// </summary>
        private static void ExcluiUsuarioPorId()
        {
            ListaUsuario();
            Console.WriteLine("Informe o ID: ");
            int id = int.Parse(Console.ReadLine());
            usuariosController.GetUsuarios(usuario);
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

            livrosController.AddLivro(new Livro()
            {
                Nome = nome,
                Ativo = true

            });
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        /// <summary>
        /// Método que lista os usuários cadastrados no sistema
        /// </summary>
        private static void ListaUsuario()
        {
            Console.WriteLine("Lista de usuários:");
            usuariosController.GetUsuarios()
                .ToList()
                .ForEach(s => Console.WriteLine($"ID: {s.Id} NOME: {s.Login} SENHA: ****** ATIVO: {s.Ativo.ToString()}"));

        }

        /// <summary>
        /// Método que Exclui/Inativa um livro do sistema
        /// </summary>
        private static void ExcluiLivroPorId()
        {
            ListaLivros();
            Console.WriteLine("Informe o ID: ");
            int id = int.Parse(Console.ReadLine());
            //livrosController.ListarLivros();
            Console.Write("Confirma inativar este livro? (S/N)");
            var confirmaExclusao = Console.ReadKey().KeyChar.ToString().ToLower();
            if (confirmaExclusao == "s")
                livrosController.DeleteLivro(id);
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
                Senha = EncryptMD5.MD5Hash(usuario.Senha),
                Ativo = true
            };

            //Console.WriteLine($"Usuário {ListaDeUsuarios[ListaDeUsuarios.Count - 1].Login} adicionado com sucesso. ID: {ListaDeUsuarios[ListaDeUsuarios.Count - 1].Id} ");
            usuariosController.AddUsuario(usuario);
            Console.WriteLine("Usuário cadastrado com sucesso! (Press any key...)");

        }

        /// <summary>
        /// Método que lista livros cdastrados no sistema
        /// </summary>               
        private static void ListaLivros()
        {
            var list = livrosController.GetLivros();
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
            Usuario usuLogin = new Usuario();
            Console.Write("Login: ");
            usuLogin.Login = Console.ReadLine();
            Console.Write("Senha: ");
            usuLogin.Senha = Console.ReadLine();

            if (usuariosController.LoginSistema(usuLogin))
            {
                logedin = usuLogin;
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// Tela inicial de Login
        /// </summary>
        private static void TelaDeLogin()
        {
            while (!RealizaLoginSistema())
                Console.WriteLine("Login ou senha inválidos");
        }

        private static void ImprimeListaUsuario(Usuario usuario)
        {
            string template = "Id: {0,3} | Login: {1,-10} | Ativo: {2,4}";
            string textoFormatado = string.Format(template,
                usuario.Id,
                usuario.Login,
                usuario.Ativo);
            Console.WriteLine(textoFormatado);

        }
    }
}

