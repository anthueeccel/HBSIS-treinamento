using MinhaSegundaClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<Frutas>
            {
                new Frutas()
                {
                    Nome = "Banana",
                    Quantidade = 3
                },
                new Frutas()
                {
                    Nome = "Morango",
                    Quantidade = 5
                },
                new Frutas()
                {
                    Nome = "Tomate",
                    Quantidade = 2
                }

             };
            minhaCestaDeFrutas.ForEach(i =>
            Console.WriteLine($"Nome: {i.Nome}, quantidade: {i.Quantidade}"));
            Console.ReadKey();
        }
    }
}
