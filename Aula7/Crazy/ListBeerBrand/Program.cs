using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBeerBrand
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListBeer();
            Console.ReadKey();
        }

        /// <summary>
        /// Método que lista 5 marcas de cerveja da Cervejaria Ambev
        /// </summary>
        public static void ListBeer()
        {
            Console.Clear();
            List<string> listaCerveja = new List<string>();

            listaCerveja.Add("Antartica");
            listaCerveja.Add("Brahma");
            listaCerveja.Add("Skol");
            listaCerveja.Add("Bohemia");
            listaCerveja.Add("Patagônia");

            Console.WriteLine("Lista de cervejas: ");
            listaCerveja.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Cervejaria Ambev(R)");
        }
    }
}
