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
                Console.WriteLine("1. Listar Veículos");
                Console.WriteLine("2. Relatórios");
                Console.WriteLine("0. Sair do sistema");
                Console.Write("Informe a opção desejada: ");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                switch (opcao)
                {
                    case 1:
                        RelatoriosVeiculosPorMes(0);
                        Console.ReadKey();
                        break;
                    case 2:
                        RelatoriosVeiculosPorMes(0);
                        Console.ReadKey();
                        break;
                    case 3:
                        
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

        /// <summary>
        /// Método para exportar os relatórios criados.
        /// </summary>
        /// <param name="mes">mês do ano informado pelo usuário</param>
        /// <param name="formato">formato escolhido pelo usuário [txt, csv, pdf]</param>
        /// <param name="lista"></param>
        private static void ExportaRelatorio(int mes, int formato, List<Veiculo> lista)
        {
            veiculoController.ExportaRelatorio(mes, formato, lista);
        }

        /// <summary>
        /// Método que cria a lista com os veículos do mês solicitado
        /// </summary>
        /// <param name="mes"></param>
        private static void RelatoriosVeiculosPorMes(int mes)
        {
            List<Veiculo> lista;

            if (mes == 0)
                lista = veiculoController.listaVeiculos();

            else
            {
                Console.WriteLine("Relatórios de Veículos por mês");
                Console.WriteLine("[1]Jan [2]Fev [3]Mar [4]Abr [5]Mai [6]Jun [7]Jul [8]Ago [9]Set [10]Out [11]Nov [12]Dez");
                Console.Write("Informe o mês do relatório: ");

                int.TryParse(Console.ReadLine(), out mes);
                lista = veiculoController.RelatorioDeVeiculosPorMes(mes);
            }
            string[] meses = veiculoController.meses;

            ImprimeDados(lista);

            Console.WriteLine($"Valor total no mês de {meses[mes]}: {lista.Sum(x => (x.Valor * x.Quantidade)).ToString("C2")}");
            Console.WriteLine($"Valor médio no mês de {meses[mes]}: {lista.Average(x => x.Valor).ToString("C2")}");
            Console.WriteLine("Deseja exportar o relatório? (S/N) ");
            var perguntaExporta = Console.ReadKey().KeyChar.ToString().ToLower();
            if (perguntaExporta == "s")
            {
                Console.WriteLine("Selecione o formato: [1]txt [2]csv [3]PDF");
                var formato = int.Parse(Console.ReadKey().KeyChar.ToString());
                ExportaRelatorio(mes, formato, lista);
            }
        }

        /// <summary>
        /// Método que imprime os dados da lista no console
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static void ImprimeDados(List<Veiculo> lista)
        {
            string template = "ID: {0,-3} | Carro: {1,-40} | Valor: {2,10} | Qtde: {3,4} | Data: {4,10}";
            lista.ForEach(v => Console.WriteLine(String.Format(template, v.Id, v.Carro, v.Valor.ToString("C2"), v.Quantidade, v.Data.ToShortDateString())));
        }
    }
}
