using System;
/// <summary>
/// Criar um console app que apresente a quantidade total de caracteres que contém em um texto informado pelo usuário.
/// </summary>
namespace Questao4
{
    class Program
    {
                      
        static void Main(string[] args)
        {
            var text = InputText();
            AnalizeText(text);

            Console.ReadKey();
        }

        /// <summary>
        /// Método que recebe um texto qualquer
        /// </summary>
        /// <returns></returns>
        private static string InputText()
        {            
            Console.WriteLine("Digite um texto: ");
            var texto = Console.ReadLine();
            return texto;
        }

        /// <summary>
        /// Método que analiza um texto e mostra o tamanho.
        /// </summary>
        /// <param name="texto">texto recebido</param>
        private static void AnalizeText(string texto)
        {
            Console.WriteLine(texto.Length);
        }
    }
}
