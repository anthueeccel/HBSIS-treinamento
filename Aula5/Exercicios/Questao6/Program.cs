using System;
/// <summary>
/// Questão 6: Criar um console app que quando informado o texto contendo banana ele troque esta informação por laranja.
/// </summary>
namespace Questao6
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
            var texto = Console.ReadLine().ToLower();
            return texto;
        }

        /// <summary>
        /// Método que analiza um texto e troca uma palavra por outra (originalText por replaceText).
        /// </summary>
        /// <param name="texto">texto recebido</param>
        private static void AnalizeText(string texto)
        {            
            var originalText = "banana";
            var replaceText = "laranja";
            texto = texto.Replace(originalText, replaceText);
            Console.WriteLine("Texto digitado: " + texto);
            Console.ReadKey();           
        }
    }
}
