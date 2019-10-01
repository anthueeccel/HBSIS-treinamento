using System;
using System.Threading;

namespace Questao7
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
            Console.Write("Digite um texto a ser analisado: ");
            //var texto = File.ReadAllText(@"C:/temp/test.txt").ToLower();
            var texto = Console.ReadLine().ToLower();
            Console.Write("\nTexto a ser analizado");
            Console.WriteLine(texto);
            return texto;
        }

        /// <summary>
        /// Método que analiza um texto e conta a quantidade de letras 'a', 'e', 'i', 'o' e 'u'.
        /// </summary>
        /// <param name="texto">texto recebido</param>
        private static void AnalizeText(string texto)
        {
            int qtdeA = texto.Split('a').Length -1;
            int qtdeE = texto.Split('e').Length -1;
            int qtdeI = texto.Split('i').Length -1;
            int qtdeO = texto.Split('o').Length -1;
            int qtdeU = texto.Split('u').Length -1;

            Console.Write("\n\r\nAnalizando texto: ");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                Console.Write("|");
            }

            Console.WriteLine("\r\nQuantidade de 'a': " + qtdeA.ToString());
            Console.WriteLine("Quantidade de 'e': " + qtdeE.ToString());
            Console.WriteLine("Quantidade de 'i': " + qtdeI.ToString());
            Console.WriteLine("Quantidade de 'o': " + qtdeO.ToString());
            Console.WriteLine("Quantidade de 'u': " + qtdeU.ToString());
        }
    }
}
