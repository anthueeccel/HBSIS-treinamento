using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCars
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaCarros();
            Console.ReadKey();
        }

        public static void ListaCarros()
        {
            Console.Clear();
            List<string> lista = new List<string>();
            lista.Add("BMW");
            lista.Add("Porsche");
            lista.Add("Mercedes");
            lista.Add("Fiat");
            lista.Add("Peugeot");

            Console.WriteLine("Lista de marcas de Carros");
            lista.ForEach(x => Console.WriteLine(x));
        }
    }
}
