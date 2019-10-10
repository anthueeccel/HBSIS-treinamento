using FloresLibrary.Controller;
using FloresLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFlores
{
    class Program
    {
        public static Flor flor = new Flor();
        public static FlorController controller = new FlorController();

        static void Main(string[] args)
        {
            
            while (true)
            {
                AdicionarFlor();

                ListarFlores();

                Console.ReadKey(true);
            }



        }

        public static void AdicionarFlor()
        {
            Console.Write("\n[NOVO] Nome da Flor: ");
            flor.Nome = Console.ReadLine();
            Console.Write("[NOVO] Quantidade: ");
            flor.Quantidade = int.Parse(Console.ReadLine());
            if (controller.AddFlor(flor))
                Console.WriteLine("Total de {0} flor(es) '{1}' cadastrada(s) com sucesso!", flor.Quantidade, flor.Nome);
            else
                Console.WriteLine("Erro ao cadastrar");
        }

        public static void ListarFlores()
        {
            Console.WriteLine("\n------Lista de Flores------");
            var listaDeFlores = controller.GetFlores()
                .OrderByDescending(x => x.Quantidade)
                .ToList();

            listaDeFlores.ForEach(x => Console.WriteLine($"Id {x.Id} |Tipo: {x.Nome}, {x.Quantidade} unidades"));
            Console.WriteLine("Total de flores: " + listaDeFlores.Sum(x => x.Quantidade));

            Console.WriteLine("------Fim da Lista------\n");
        }




    }
}
