using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informar texto: ");
            var conteudoDoTexto = Console.ReadLine();

            for (int i = 0; i < conteudoDoTexto.Length; i++)
            {
                Console.WriteLine(conteudoDoTexto[i]);
            }

            Console.ReadKey();
        }
    }
}
