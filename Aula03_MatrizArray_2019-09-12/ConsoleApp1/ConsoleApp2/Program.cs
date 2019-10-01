using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome a ser calculado: ");
            var nomeLength = Console.ReadLine();

            Console.WriteLine($"O tamanho deste nome é: {nomeLength.Length} caracteres");


            Console.ReadKey();

        }
    }
}
