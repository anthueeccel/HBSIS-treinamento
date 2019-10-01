using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systemas.Model;

namespace Systemas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeAmigos = new List<Amigos>
            {
                new Amigos()
                {
                    Nome = "Paulo",
                    TempoDeAmizade = 21
                },
                new Amigos()
                {
                    Nome = "Daniel",
                    TempoDeAmizade = 29
                },
                new Amigos()
                {
                    Nome = "Luciane",
                    TempoDeAmizade = 3
                }

             };

            listaDeAmigos.ForEach(x => Console.WriteLine($"Nome: {x.Nome} tempo de amizade: {x.TempoDeAmizade} anos"));
            Console.ReadKey();

        }
}
}
