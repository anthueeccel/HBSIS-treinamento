using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "XAIOMI Lite 6 Quad Core 128Gb",
                    Quantidade = 8,  
                    Valor = 1200.75
                },
                new Venda()
                {
                    Produto = "IPHONE XL",
                    Quantidade = 1,
                    Valor  = 9999.99
                },
                new Venda()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5, 
                    Valor = 2800.96
                }
            };
            Console.Write("Média de produtos vendidos neste mês: ");
            Console.WriteLine(vendas.Average(x => x.Quantidade).ToString("N1"));
            Console.WriteLine("Média de valor dos produtos vendidos neste mês: ");
            Console.WriteLine(vendas.Average(x => x.Quantidade * x.Valor).ToString("C2"));

            Console.ReadKey();
        }
    }
}
