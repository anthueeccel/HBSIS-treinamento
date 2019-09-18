using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarListas
    {
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
