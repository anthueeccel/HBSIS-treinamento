using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoQuadrado
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        /// <summary>
        /// Método que calcula a área de um quadrado.
        /// </summary>
        public static void CalculoAreaQuadrado()
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área de um quadrado.");
            Console.Write("Digite o lado: ");
            Console.WriteLine($"A área é: {int.Parse(Console.ReadLine())*2}");            
        }
    }
}
