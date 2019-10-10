using NomesLibrary.Controller;
using NomesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomes
{
    class Program
    {
        public static  NomeController controller = new NomeController();
        public static Nome nome = new Nome();

        static void Main(string[] args)
        {

            AdicionaNome();

            ListarNomes();


            Console.ReadKey(); 


        }

        public static void AdicionaNome()
        {
            Console.WriteLine("NOVO NOME");
            Console.Write("Informe o nome: ");
            nome.ONome = Console.ReadLine();
            if(controller.AddNome(nome))
            Console.WriteLine("Nome inserido com sucesso!");
            else
                Console.WriteLine("Erro ao inserir o nome");
        }

        public static void ListarNomes()
        {
            Console.WriteLine("Lista de nomes cadastrados");
            controller.GetNomes().ToList().ForEach(x => Console.WriteLine(x.ONome));
            Console.WriteLine("Fim da Lista ============");
        }


    }
}
