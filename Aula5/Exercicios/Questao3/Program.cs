using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/// <summary>
/// Questão 3: Criar um console app que solicite o nome e a idade, e após informar nome e idade o mesmo
/// deverá apresentar quando maior ou igual a 18 anos a seguinte informação:
/// "Parabéns {nome} você já esta na fase adulta."
/// caso menor de 18 anos o mesmo deverá apresentar a seguinte informação:
/// "Calma {nome} tudo ao seu tempo, logo você terá 18 anos de idade."
/// </summary>
namespace Questao3
{
    class Program
    {
        public struct Pessoa
        {
            public string nome;
            public int idade;
        }

        static void Main(string[] args)
        {
            ShowInitApp();
            Pessoa pessoa = AskData();
            AnalizeData(pessoa);
            Console.ReadKey();

            ExitAppMsg();
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo de finalização do sistema
        /// </summary>
        private static void ExitAppMsg()
        {
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-----Obrigado por utilizar nosso sistema----");
            Console.WriteLine("------------------HBSIS---------------------");
        }

        /// <summary>
        /// Métodos de boas vindas.
        /// </summary>
        private static void ShowInitApp()
        {
            Console.WriteLine("\nBem vindo ao sitema!\n\n");
        }

        /// <summary>
        /// Método para receber os dados solicitados ao usuário nome e idade
        /// </summary>
        /// <returns>retorna objeto (struct) Pessoa</returns>
        private static Pessoa AskData()
        {
            var pessoa = new Pessoa();
            Console.WriteLine("Digite o seu nome: ");
            pessoa.nome = Console.ReadLine().Trim();
            Console.WriteLine("Digite o sua idade: ");
            pessoa.idade = int.Parse(Console.ReadLine().Trim());

            return pessoa;
        }

        /// <summary>
        /// Métodos para analisar os dados recebidos Pessoa e retornar mensagem
        /// </summary>
        /// <param name="pessoa">pessoa.name e pessoa.idade</param>
        private static void AnalizeData(Pessoa pessoa)
        {
            string idadeMsg;
            if (pessoa.idade < 18)
                idadeMsg = $"Calma {pessoa.nome} tudo ao seu tempo, você tem apenas {pessoa.idade} logo você terá 18 anos de idade. você já esta na fase adulta.";
            else            
                idadeMsg = $"Parabéns {pessoa.nome}, você tem {pessoa.idade} e já esta na fase adulta.";
            
            Console.WriteLine(idadeMsg);
        }
    }
}
