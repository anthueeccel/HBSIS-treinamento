using DllPastaWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemPasta
{
    class Program
    {

        static DocumentsAutoGenerate doc = new DocumentsAutoGenerate();
        //Directory

        static void Main(string[] args)
        {

            var menu = int.MinValue;

            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Pasta");
                Console.WriteLine("1 - Listar as Pastas em MeusDocumentos");
                Console.WriteLine("2 - Criar Pasta em MeusDocumentos");
                Console.WriteLine("3 - Excluir Pasta em MeusDocumentos");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        ListarPasta();
                        Console.ReadKey();
                        break;
                    case 2:
                        CriarPasta();
                        Console.ReadKey();
                        break;
                    case 3:
                        ExcluirPasta();
                        Console.ReadKey();
                        break;
                    case 4:
                        new HoraDoShow().Birllllllllll();
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
            }


        }

        public static void ListarPasta()
        {
            try
            {
                var listaPasta = doc.ObterPastasDiretorioMeuDocumentos().ToList();
                listaPasta.ForEach(x => Console.WriteLine($"{x.ToString()}"));
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao criar pasta");
                throw;
            }

        }

        public static void CriarPasta()
        {
            Console.Write("Criar Pasta - nome: ");
            string nomeDaPasta = Console.ReadLine();
            Console.WriteLine("Criar pasta? " + nomeDaPasta);
            var criarPasta = Console.ReadLine().ToLower();
            try
            {
                if (criarPasta == "s")
                    doc.CriarPastaMeusDocumentos(nomeDaPasta);
                Console.WriteLine("Pasta criada com sucesso!");

            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao Criar a pasta");
                throw;
            }
        }

        public static void ExcluirPasta()
        {
            Console.Write("Qual pasta quer excluir? ");
            var nomeDaPasta = Console.ReadLine();
            try
            {
                doc.DeletarPastaMeusDocumentos(nomeDaPasta, true);
                Console.WriteLine("Excluída com sucesso!");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao excluir");
                throw;
            }
        }

    }
}
