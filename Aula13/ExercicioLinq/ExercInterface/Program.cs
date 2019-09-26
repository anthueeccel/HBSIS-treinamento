using ClassLibrary.Controller;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface
{
    class Program
    {
        public static VeiculoController veiculoController = new VeiculoController();

        static void Main(string[] args)
        {
            MenuInicial();

        }

        /// <summary>
        /// Método que exibe o menu inicial do sistema
        /// </summary>
        public static void MenuInicial()
        {
            int opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("========= Sistema V.Car1.0 =========");
                Console.WriteLine("- Veículos");
                Console.WriteLine("--- 1. Listar");
                Console.WriteLine("---2. Relatórios");
                Console.WriteLine("- 0. Sair do sistema");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                switch (opcao)
                {
                    case 1:
                        ListarVeiculos();
                        Console.ReadKey();
                        break;
                    case 2:
                        RelatoriosVeiculosPorMes();
                        Console.ReadKey();
                        break;
                    case 3:

                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por utilizar V.Car (Pressione Enter)");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }


        }

        private static void RelatoriosVeiculosPorMes()
        {
            Console.WriteLine("Relatórios de Veículos por mês");
            Console.WriteLine("[1]Jan [2]Fev [3]Mar [4]Abr [5]Mai [6]Jun");
            Console.WriteLine("[7]Jul [8]Ago [9]Set [10]Out [11]Nov [12]Dez");
            Console.Write("Informeo mês do relatório: ");
            int mes;
            int.TryParse(Console.ReadLine(), out mes);
            var lista = veiculoController.RelatorioDeVeiculosPorMes(mes);
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            ImprimeDados(lista);

            Console.WriteLine($"Valor total no mês de {meses[mes - 1]}: {lista.Sum(x => (x.Valor * x.Quantidade)).ToString("C2")}");
            Console.WriteLine($"Valor médio no mês de {meses[mes - 1]}: {lista.Average(x => x.Valor).ToString("C2")}");
        }
        /// <summary>
        /// Método que lista todos os veículos cadastrados no sistema
        /// </summary>                
        public static void ListarVeiculos()
        {
            ImprimeDados(veiculoController.listaVeiculos());
        }

        public static void ImprimeDados(List<Veiculo> lista)
        {
            string template = "ID: {0,-3} | Carro: {1,-40} | Valor: {2,10} | Qtde: {3,4} | Data: {4,10}";
            lista.ForEach(v => Console.WriteLine(String.Format(template, v.Id, v.Carro, v.Valor.ToString("C2"), v.Quantidade, v.Data.ToShortDateString())));
        }
    }
}
