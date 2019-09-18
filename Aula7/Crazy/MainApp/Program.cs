using System;
using MinhaBiblioteca;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        public static string menuEscolhido = string.Empty;

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Crazy");
            MenuSistema();
            Console.Clear();
            Console.WriteLine("\n\n\nObrigado por utilizar nosso sistema");
            Console.ReadKey();
        }
        /// <summary>
        /// Menu com as opções do sistema.
        /// </summary>
        private static void MenuSistema()
        {

            Console.WriteLine("\n------- M E N U -----------");
            Console.WriteLine("1 - Cálculo de área");
            Console.WriteLine("2 - Mostrar Árvore");
            Console.WriteLine("3 - Listas");
            Console.WriteLine("4 - Sair do sistema");
            Console.Write("Escolha uma das opções do menu: ");
            menuEscolhido = Console.ReadKey().KeyChar.ToString();

            switch (menuEscolhido)
            {
                case "1":
                    {
                        CalculaArea();
                        MenuSistema();
                    }
                    break;
                case "2":
                    {
                        AnimacaoEmFrames.AnimacaoArvore();
                        MenuSistema();
                    }
                    break;
                case "3":
                    {
                        SubmenuListas();
                    }
                    break;
                case "4":
                    break;
                default:
                    MenuSistema();
                    break;

            }
        }

        /// <summary>
        /// Submenu de Listas
        /// </summary>
        private static void SubmenuListas()
        {
            Console.Clear();
            menuEscolhido = string.Empty;
            Console.WriteLine("- Submenu: Listas --------");
            Console.WriteLine("[1]Cervejas [2]Carros [3]Voltar");
            Console.Write("Escolha uma opção: ");
            menuEscolhido = Console.ReadKey().KeyChar.ToString();

            switch (menuEscolhido)
            {
                case "1":
                    {
                        MostrarListas.ListBeer();
                        MenuSistema();
                    }
                    break;
                case "2":
                    {
                        MostrarListas.ListaCarros();
                        MenuSistema();
                    }
                    break;
                case "3":
                    {
                        MenuSistema();
                    }
                    break;
                default:
                    MenuSistema();
                    break;
            }
        }
        /// <summary>
        /// Método para cálculo de área de quadrado
        /// </summary>
        public static void CalculaArea()
        {
            Console.Write("\nInforma o lado do quadrado: ");
            double ladoQuadrado = double.Parse(Console.ReadLine());
            var bibliotecaCalculos = new CalculosDeArea();
            Console.WriteLine($"A área do quadrado é {bibliotecaCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}");
        }
        /// <summary>
        /// (DEPRECADO) Menu inicial do sistema
        /// </summary>
        private static void MenuInicial()
        {

            string opcao = string.Empty;
            while (opcao != "6")
            {
                Console.WriteLine("\n\n\n[1]Calculadora [2]Lista cervejas [3]Lista carros [4]Árvore [5]Árvore animada [6]Sair");
                Console.WriteLine("Digite a opção desejada");
                opcao = Console.ReadKey().KeyChar.ToString();

                switch (opcao)
                {
                    case "1":
                        CalculoQuadrado.Program.CalculoAreaQuadrado();
                        break;
                    case "2":
                        ListBeerBrand.Program.ListBeer();
                        break;
                    case "3":
                        ListCars.Program.ListaCarros();
                        break;
                    case "4":
                        TreeApp.Program.ArvoreNoConsole();
                        break;
                    case "5":
                        TreeApp.Program.Frame1();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
