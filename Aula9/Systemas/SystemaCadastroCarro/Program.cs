using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using SystemaCadastroCarro.Model;

namespace SystemaCadastroCarro
{
    class Program
    {
        public static string marca;
        public static string modelo;
        public static int ano;
        public static double valor;
        public static string placa;

        public static List<Carro> listaDeCarros = new List<Carro>();

        static void Main(string[] args)
        {
            WelcomeMessage();
            var listaDeCarros = CadastroDeCarro();
            ListarCarros(listaDeCarros);

            Console.ReadKey();
        }

        /// <summary>
        /// Método que cadastra os carros no sistema
        /// </summary>
        /// <returns>lista de carros List<Carro></Carro></returns>
        private static List<Carro> CadastroDeCarro()
        {
            Console.WriteLine("Cadastro > Novo Carro");
            Console.Write("Informe a marca: ");
            marca = Console.ReadLine();
            Console.Write("Informe o modelo: ");
            modelo = Console.ReadLine();
            Console.Write("Informe o ano de fabricação: ");
            int.TryParse(Console.ReadLine(),out ano);
            Console.Write("Informe o valor: R$");
            valor = double.Parse(Console.ReadLine());
            bool informaPlaca = false;
            while (!informaPlaca)
            {
                Console.Write("Informe a placa (somente letras e números): ");
                placa = Console.ReadLine().ToUpper().Replace("-", "");
                if (validaPlaca(placa))
                    informaPlaca = true;
                else if (!validaPlaca(placa))
                {
                    Console.WriteLine("Placa inválida.");
                    informaPlaca = false;
                }
            }
            
            listaDeCarros.Add(new Carro()
            {
                Marca = marca,
                Modelo = modelo,
                Ano = ano,
                Valor = valor,
                Placa = placa
            });

            Console.WriteLine("Cadastrar novo? (S/N)");
            var resposta = Console.ReadKey().KeyChar.ToString().ToLower();
            if (resposta == "s")
            {
                Console.Clear();
                CadastroDeCarro();
            }
            return listaDeCarros;


        }
        /// <summary>
        /// Imprime no console a lista de carros
        /// </summary>
        /// <param name="listaDeCarros"></param>
        private static void ListarCarros(List<Carro> listaDeCarros)
        {
            Console.Clear();
            Console.WriteLine("Lista de carros cadastrados");

            listaDeCarros.ForEach(k => Console.WriteLine($"Marca: {k.Marca}, modelo: {k.Modelo}, ano: {k.Ano}, valor R${k.Valor}, placa: {k.Placa}"));
        }
        /// <summary>
        /// Tela inicial de boas vindas ao sistema
        /// </summary>
        private static void WelcomeMessage()
        {
            Console.WriteLine("\n\n\n--------------------------------------------");
            Console.WriteLine("Bem vindo ao sistema de cadastro de carros");
            Console.WriteLine("--------------------------------------------");
            Thread.Sleep(800);
            Console.Clear();
        }
        /// <summary>
        /// Método para valida a placa - Mercosul e Brasil
        /// </summary>
        /// <param name="placa">placa do veículo <String></param>
        /// <returns>true ou false</returns>
        private static bool validaPlaca(string placa)
        {
            if (placa.Length == 7)
            {
                Regex regex = new Regex(@"^[A-Z]{3}[0-9]{4}");
                Regex regexMercosul = new Regex(@"^[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}");

                if (regex.IsMatch(placa))
                    return true;

                if (regexMercosul.IsMatch(placa))
                    return true;
            }
            return false;
        }

    }
}
