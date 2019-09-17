using System;
using System.Collections.Generic;
using System.Globalization;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListaDateTime();
            //ListaString();
            //ListaInteiros();
            //ListaDecimais();

          
            ConsultaCotacaoAPI api = new ConsultaCotacaoAPI();
            double cotacao = api.GetCotacao("USD-BRL");        




            Console.ReadKey();

        }
        /// <summary>
        /// Método para criar, popular e imprimir uma instância DateTime
        /// </summary>
        /// <typeparam name="DateTime"></typeparam>
        private static void ListaDateTime()
        {
            Console.WriteLine("\nLista DateTime");

            var minhaLista = new List<DateTime>();
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20).AddDays(102));
            minhaLista.Add(DateTime.Now);

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyy/MMMMM/dd")));

        }
        /// <summary>
        /// Método para criar, popular e imprimir uma lista de string
        /// </summary>
        private static void ListaString()
        {
            Console.WriteLine("\nLista String");
            var minhaLista = new List<string>();
            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i));

        }
        /// <summary>
        /// Método para criar, popular e imprimir uma lista de inteiros
        /// </summary>
        private static void ListaInteiros()
        {
            Console.WriteLine("\nLista Inteiros");
            var minhaListInt = new List<int>();
            minhaListInt.Add(17);
            minhaListInt.Add(18);
            minhaListInt.Add(19);
            minhaListInt.Add(20);

            minhaListInt.ForEach(meuInteiro => Console.WriteLine(meuInteiro));

        }
        /// <summary>
        /// Método para criar, popular e imprimit uma lista de Decimais
        /// </summary>
        private static void ListaDecimais()
        {
            Console.WriteLine("\nLista Decimais");
            var listaDec = new List<double>();
            listaDec.Add(30.75);
            listaDec.Add(450.98);
            listaDec.Add(20550.42);
            listaDec.Add(10.05);


            // listaDec.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("R$ ###0.##")));
            // listaDec.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C")));
            listaDec.ForEach(meuDecimal => Console.WriteLine($"Moeda local: {meuDecimal.ToString("C")} nos EUA equivale a {FormataNumeroDecimalEmDolar(meuDecimal, "en-US", 4.50)} dólares"));
            listaDec.ForEach(meuDecimal => Console.WriteLine($"Moeda local: {meuDecimal.ToString("C")} no Japão equivale a {FormataNumeroDecimalEmDolar(meuDecimal, "ja-JP", 0.0378)} ien"));
            listaDec.ForEach(meuDecimal => Console.WriteLine($"Moeda local: {meuDecimal.ToString("C")} na Europa equivale a {FormataNumeroDecimalEmDolar(meuDecimal, "de-DE", 5.10)} euros"));
            listaDec.ForEach(meuDecimal => Console.WriteLine($"Moeda local: {meuDecimal.ToString("C")} em Bitcoin equivale a {FormataNumeroDecimalEmDolar(meuDecimal, "", 41810.19)} bitcoin"));

        }

        /// <summary>
        /// Método que retornar a cotação Real na moeda selecionada
        /// </summary>
        /// <param name="meuNumero">número em Reais</param>
        /// <param name="culture">localidade</param>
        /// <param name="taxaConversao">valor para conversão da moeda</param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero, string culture, double taxaConversao)
        {
            if (culture.Equals(""))
                return (meuNumero / taxaConversao).ToString("B$ ###0.##");
            return (meuNumero * taxaConversao).ToString("C", CultureInfo.CreateSpecificCulture(culture));

        }
    }
}
