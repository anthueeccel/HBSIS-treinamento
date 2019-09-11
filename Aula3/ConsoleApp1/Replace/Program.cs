using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Informe uma sequencia de números: ");
            //var textContent = Console.ReadLine();

            //Console.WriteLine(textContent.Replace("3", "Banana"));
            //Console.ReadKey();



            var primeiroText = "Olá, meu nome é Anthue e eu Anthue gosto de codar muito e eu Anthue estou com muita vontade de começar a codar";
            Console.WriteLine(primeiroText);
            Console.WriteLine($"Texto contem: {primeiroText.Length} caracteres");

            primeiroText = primeiroText
                .Replace("Anthue", "1")
                .Replace("codar", "2")
                .Replace("eu","3");

            Console.WriteLine(primeiroText);
            Console.WriteLine($"Texto contem: {primeiroText.Length} caracteres");

            bool? testeBool; //permite receber boleano nulo.

            primeiroText = primeiroText
                .Replace("1", "Anthue")
                .Replace("2", "codar")
                .Replace("3", "eu");
            Console.WriteLine(primeiroText);
            Console.WriteLine($"Texto contem: {primeiroText.Length} caracteres");

            


            Console.ReadKey();





        }
    }
}
