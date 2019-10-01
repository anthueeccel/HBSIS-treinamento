using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroPrimitivos();

            SomaInteirosLista();
            
            SomaBalasListaDeCriancas();

            Console.ReadKey();

        }


        /// <summary>
        /// Método que efetua a soma de inteiros (Array)
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            // Array de inteiros
            int[] colecaoInteiros = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(colecaoInteiros.Sum());


        }

        /// <summary>
        /// Método que efetua a soma de um em um de inteiros (Lista)
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine(listaDeInteiros.Sum());


        }

        /// <summary>
        /// Método que soma a quantidade de balas das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            List<Crianca> criancas = new List<Crianca>()
            {
                new Crianca()
                {
                    Nome = "Joãozinho",
                    Balas = 9
                },
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                },      
            };
            Console.WriteLine(criancas.Sum(x => x.Balas));
        }
    }

}
