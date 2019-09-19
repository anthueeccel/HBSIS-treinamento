using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using SystemaCadastroPessoas.Model;

namespace SystemaCadastroPessoas
{
    class Program
    {
        public static string nome;
        public static int idade;
        public static char sexo;
        public static double altura;
        public static string cpfCnpj;
        public static List<Pessoa> listaDePessoas = new List<Pessoa>();

        static void Main(string[] args)
        {
            WelcomeMessage();
                                          
            //var listaDePessoas = CadastroDePessoa();
            //ListarPessoas(listaDePessoas);

            listaDePessoas = populaListaPessoa();

            List<Pessoa> menoresIdade = new List<Pessoa>();
            foreach (Pessoa p in listaDePessoas)
            {
                if (p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }
            }

            listaDePessoas.Where(p => p.Idade > 18);

            var listaOrdenada = listaDePessoas.OrderBy(p => p.Nome ).ThenBy(p => p.Idade).ToList();
            listaOrdenada.ForEach(c => Console.WriteLine($"Nome: {c.Nome}"));

            Console.ReadKey();
        }
        /// <summary>
        /// Tela de boas vindas ao sistema
        /// </summary>
        private static void WelcomeMessage()
        {
            Console.WriteLine("\n\n\n--------------------------------------------");
            Console.WriteLine("Bem vindo ao sistema de cadastro de pessoas");
            Console.WriteLine("--------------------------------------------");
            Thread.Sleep(800);
            Console.Clear();
        }
        /// <summary>
        /// Método para imiprimir no console a lista de pessoas cadastradas no sistema
        /// </summary>
        /// <param name="listaDePessoas">List<Pessoa></param>
        private static void ListarPessoas(List<Pessoa> listaDePessoas)
        {
            Console.Clear();
            Console.WriteLine("Lista de pessoas cadastradas no sistema");
            Console.WriteLine("Nome    |Idade|Sexo|Altura|Cpf/Cnpj");
            listaDePessoas.ForEach(i => Console.WriteLine($"{i.Nome}    {i.Idade}, {i.Sexo}, {i.Altura}, {i.CpfCnpj}"));
        }
        /// <summary>
        /// Método para cadastrar pessoas no sistema.
        /// </summary>
        /// <returns>lista de pessoa List<Pessoa></returns>
        private static List<Pessoa> CadastroDePessoa()
        {
            Console.WriteLine("Cadadastro:");
            bool informaCpfCnpj = false;
            while (!informaCpfCnpj)
            {
                Console.Write("Informe o Cpf ou Cnpj: ");
                cpfCnpj = Console.ReadLine().Replace(".", "").Replace("/", "").Replace("-", "");
                if (validaCpfCnpj(cpfCnpj))
                    informaCpfCnpj = true;
                else if (!validaCpfCnpj(cpfCnpj))
                {
                    Console.WriteLine("Cpf ou Cnpj inválido.");
                    informaCpfCnpj = false;
                }
            }
            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe a idade (anos): ");
            int.TryParse(Console.ReadLine(), out idade);
            if (cpfCnpj.Length == 11)
            {
                Console.Write("Informe o sexo (M / F): ");
                char.TryParse(Console.ReadLine(), out sexo);
                Console.Write("Informe a altura (0.00): ");
                double.TryParse(Console.ReadLine(), out altura);
            }
            else
            {
                sexo = '-';
                altura = 0.0;
            }

            listaDePessoas.Add(new Pessoa()
            {
                Nome = nome,
                Idade = idade,
                Sexo = sexo,
                Altura = altura

            });

            Console.WriteLine("Cadastrar mais? (S/N)");
            var resposta = Console.ReadKey().KeyChar.ToString().ToUpper();
            if (resposta == "S")
            {
                Console.Clear();
                CadastroDePessoa();
            }
            return listaDePessoas;
        }
        /// <summary>
        /// Método para validar Cpf e Cnpj
        /// </summary>
        /// <param name="CpfCnpj">número do Cpf ou Cnpj</param>
        /// <returns>true ou false</returns>
        public static bool validaCpfCnpj(string CpfCnpj)
        {
            if (CpfCnpj.Length == 11 || CpfCnpj.Length == 14)
            {
                Regex regexCpf = new Regex(@"^[0-9]{11}");
                Regex regexCnpj = new Regex(@"^[0-9]{14}");

                if (regexCpf.IsMatch(CpfCnpj))
                    return true;

                if (regexCnpj.IsMatch(CpfCnpj))
                    return true;
            }
            return false;
        }
        

        public static List<Pessoa> populaListaPessoa()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Sexo = 'M';
            p1.Altura = 2.01;
            p1.Idade = 29;
            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Elora";
            p2.Sexo = 'F';
            p2.Altura = 1.53;
            p2.Idade = 21;
            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "Anthue";
            p3.Sexo = 'M';
            p3.Altura = 1.84;
            p3.Idade = 40;
            pessoas.Add(p3);

            Pessoa p4 = new Pessoa();
            p4.Nome = "Michel";
            p4.Sexo = 'M';
            p4.Altura = 1.76;
            p4.Idade = 17;
            pessoas.Add(p4);

            return pessoas;

        }
    }
}
