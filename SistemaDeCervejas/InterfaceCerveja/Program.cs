using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCerveja
{
    class Program
    {
        public static CervejaController cervejaController = new CervejaController();

        static void Main(string[] args)
        {
            //ListaCervejas();
            //Console.ReadKey();

            //AdicionaCerveja();
            //Console.ReadKey();

            //ValorTotalCervejas();
            //Console.ReadKey();

            //TotalCervejasEmLitros();
            //Console.ReadKey();

            //ListaCervejas();
            //Console.ReadKey();

            BebeuDemais();
            Console.ReadKey();


        }


        public static void ListaCervejas()
        {
            ImprimeListaCerveja(cervejaController.GetCervejas());
        }

        private static void ImprimeListaCerveja(List<Cerveja> cerveja)
        {
            cerveja.ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome} Litros {x.Litros} Alcool: {x.Alcool} Valor: {x.Valor} "));
        }

        public static void AdicionaCerveja()
        {
            Cerveja cerveja = new Cerveja();

            Console.WriteLine("Informe os dados para cadastrar");
            Console.Write("Nome: ");
            cerveja.Nome = Console.ReadLine();
            Console.Write("Medida em Ml: ");
            double medidaEmMl = double.Parse(Console.ReadLine());
            cerveja.Litros = medidaEmMl / 1000;
            Console.Write("Percentual alcoólico (0.00): ");
            cerveja.Alcool = double.Parse(Console.ReadLine());
            Console.Write("Valor: R$");
            cerveja.Valor = double.Parse(Console.ReadLine());

            if (cervejaController.AddCerveja(cerveja))
                Console.WriteLine("Produto adicionado com sucesso!");
            else
                Console.WriteLine("Erro ao adicionar,");
        }

        public static void ValorTotalCervejas()
        {
            Console.WriteLine($"Valor total:  {cervejaController.SomaValorCervejas().ToString("C2")}");
        }

        public static void TotalCervejasEmLitros()
        {
            Console.WriteLine($"Total de litros: {cervejaController.SomaCervejasEmLitros().ToString("N3")}");
        }

        public static void BebeuDemais()
        {
            Console.Write("Qual o seu peso? ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Sexo (M/F): ");
            String sexo = Console.ReadLine().ToLower();

            double alcoolNoSnague = cervejaController.TesteAlcoolometria(peso, sexo);

            Console.WriteLine("Seu consumo:");
            ListaCervejas();
            if (alcoolNoSnague > 0.016)
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!NÃO DIRIJA!!!!!!!!!!!!!!!!!!!!!!!!\nNível de alcool no sangue acima do permitido: "
                    + alcoolNoSnague.ToString("N3"));
            else
                Console.WriteLine("Pode dirigir e/ou andar de bicicleta");


        }

    }
}
