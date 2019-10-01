using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>()
        {
                "Anthue",
                "Felipe",
                "Tiburcio"
        };

        static void Main(string[] args)
        {
            ListaInformacoes();
            var tamanhoListaInicial = minhaListaPulgmatica.Count();
            AdicionarItensALista();
            
            var tamanhoListaAtual = minhaListaPulgmatica.Count();
            Console.WriteLine("\n\nRecentmente adicionados:");
            for (int i = tamanhoListaInicial; i < tamanhoListaAtual; i++)
            {
                Console.WriteLine(minhaListaPulgmatica.ElementAt(i));
            }


            OrganizaInformacoes();
            Console.WriteLine("\n\nLista completa:");
            ListaInformacoes();
            Console.ReadKey();
        }
        /// <summary>
        /// Método que adicina um item a lista
        /// </summary>
        private static void AdicionarItensALista()
        {           
            Console.Write("Informe um nome: ");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.WriteLine($"Nome: {minhaListaPulgmatica.LastOrDefault()} adicionado");
            Console.WriteLine("Deseja informar mais valores? [s]sim [n]não");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();            

        }

        /// <summary>
        /// Método que imprime a lista na tela
        /// </summary>
        private static void ListaInformacoes()
        {
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine(item);
        }

        private static void OrganizaInformacoes()
        {
            minhaListaPulgmatica.Sort();
        }
    }
}
