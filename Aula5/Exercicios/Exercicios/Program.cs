using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Questão 1: Criar um console app que apresente as boa vindas mostre um texto, e depois indique que o mesmo 
/// deverá apertar qualquer tecla para finalizar.
/// </summary>
namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitApp();
            Console.ReadKey();

        }

        /// <summary>
        /// Método de boas-vindas.
        /// </summary>
        private static void ShowInitApp()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("--Seja bemvindo!--");
            Console.WriteLine("------------------");
        }
    }
}
