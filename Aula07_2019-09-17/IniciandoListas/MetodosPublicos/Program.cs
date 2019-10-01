using ForeachNaLista;
using System;
using System.Globalization;

namespace MetodosPublicos
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("---Sistema de conversão de moedas---");
            Console.Write("Informe o valor a ser convertido: ");
            var valorAConverter = (double.Parse(Console.ReadLine())); //está trazendo valor na API vezes 1000

            Console.WriteLine("Converter para moeda:");
            Console.WriteLine("[1]Dolar [2]Euro [3]Iene [4]Bitcoin [5]Libra Esterlina");
            int moedaAlvo = int.Parse(Console.ReadLine());

            ConsultaCotacaoAPI api = new ConsultaCotacaoAPI();
            switch (moedaAlvo)
            {
                case 1:
                    Console.WriteLine($"Valor convertido: {FormataNumeroDecimalEmDolar(valorAConverter, "en-US", (api.GetCotacao("USD-BRL")))} (Dólares americanos)");
                    break;
                case 2:
                    Console.WriteLine($"Valor convertido: {FormataNumeroDecimalEmDolar(valorAConverter, "de-DE", api.GetCotacao("EUR-BRL"))} (Euros)");
                    break;
                case 3:
                    Console.WriteLine($"Valor convertido: {FormataNumeroDecimalEmDolar(valorAConverter, "ja-JP", api.GetCotacao("JPY-BRL"))} (Ienes)");
                    break;
                case 4:
                    Console.WriteLine($"Valor convertido: {FormataNumeroDecimalEmDolar(valorAConverter, "BTC", api.GetCotacao("BTC-BRL"))} (Bitcoin)");
                    break;
                case 5:
                    Console.WriteLine($"Valor convertido: {FormataNumeroDecimalEmDolar(valorAConverter, "en-GB", api.GetCotacao("GBP-BRL"))} (Libras Esterlinas)");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.ReadKey();


        }


        /// <summary>
        /// Método que retornar a cotação Real na moeda selecionada
        /// </summary>
        /// <param name="meuNumero">número em Reais</param>
        /// <param name="culture">localidade</param>
        /// <param name="taxaConversao">valor para conversão da moeda</param>
        /// <returns></returns>
        public static string FormataNumeroDecimalEmDolar(double meuNumero, string culture, double taxaConversao)
        {
            if (culture.Equals("BTC"))
                return (meuNumero / taxaConversao).ToString("B$ ###0,##");
            return (meuNumero/taxaConversao).ToString("C", CultureInfo.CreateSpecificCulture(culture));

        }
    }
}
