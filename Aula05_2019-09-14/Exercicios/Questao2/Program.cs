using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Criar um console app que apresente as boas vindas, solicite o nome do usuário. completo e 
/// mostre uma mensagem de boas vindas com o nome do usuário.
/// </summary>
namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitApp();
            var nome = AskName();
            ShowMessage(nome);

            Console.ReadKey();


        }

        /// <summary>
        /// Métodos inicial do sistema. Boas vindas.
        /// </summary>
        private static void ShowInitApp()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("--Seja bemvindo!--");
            Console.WriteLine("------------------");
        }

        /// <summary>
        /// Método que pergunta o nome ao usuário
        /// </summary>
        /// <returns>nome do usuário <String></returns>
        private static string AskName()
        {
            Console.WriteLine("Digite o seu nome: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Método que recebe um nome e escreve uma mensagem de boas vindas.
        /// </summary>
        /// <param name="name">string nome</param>
        private static void ShowMessage(string name)
        {
            Console.WriteLine($"Olá {name}, muito bom ve-lo por aqui!");
        }
    }
}
