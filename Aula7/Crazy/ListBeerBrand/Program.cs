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

        public static void ListBeer()
        {
            List<string> listaCerveja = new List<string>();

            listaCerveja.Add("Antartica");
            listaCerveja.Add("Brahma");
            listaCerveja.Add("Skol");
            listaCerveja.Add("Bohemia");
            listaCerveja.Add("Patagônia");

            listaCerveja.ForEach(x => Console.WriteLine(x));
            
        }
    }
}
