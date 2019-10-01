using System;
/// <summary>
/// Criar um console app que apresente o primeiro e o ultimo caractere de uma palavra informada.
/// </summary>
namespace Questao5
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
            Console.Write("Digite um texto: ");
            var texto = Console.ReadLine();
            return texto;
        }

        /// <summary>
        /// Método que analiza um texto e mostra o primeiro e último caracter.
        /// </summary>
        /// <param name="texto">texto recebido</param>
        private static void AnalizeText(string texto)
        {
            Console.WriteLine("Primeiro caracter digitado: " + texto[0]);
            Console.WriteLine("Último caracter digitado: " + texto[(texto.Length -1)]);
        }
    }
}
