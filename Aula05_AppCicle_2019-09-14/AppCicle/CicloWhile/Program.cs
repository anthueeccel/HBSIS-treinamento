using System;
using System.Collections.Generic;
using System.Threading;

namespace CicloWhile
{
    class Program
    {
        public static object Tread { get; private set; }

        static void Main(string[] args)
        {
            ShowInitAppText();
            ClearScreen(990);

            List<String> lista = new List<string>();
            while (AskToContinue() == 1)
            {
                lista.Add(AskName());
                lista.Add(AskAge().ToString());
                ClearScreen(3000);
            }
            ConsultaLista(lista);

            Console.ReadKey();
        }
        /// <summary>
        /// Método que imprime a lista de dados.
        /// </summary>
        /// <param name="lista">nome e idade</param>
        private static void ConsultaLista(List<string> lista)
        {

                Console.WriteLine("\n\n\n\r\nId | Nome            | idade");
            for (int i = 0; i < (lista.Count - 1); i++)
            {
                Console.WriteLine($"{i} | nome: {lista[i]} | {lista[i + 1]}");
                i++;
            }
        }


        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");


        }

        /// <summary>
        /// Método para pergunta se deja continuar
        /// </summary>
        /// <returns>retorna o valor inserido</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());

        }

        /// <summary>
        /// Método para confirmar a finalização do programa
        /// </summary>
        /// <returns>retorna a resposta s ou n</returns>
        private static string AskToConfirm(string resposta)
        {
            Console.WriteLine("Tem certeza? (s)Sim (n)Não");
            return Console.ReadKey().KeyChar.ToString();
        }

        private static int AskAge()
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if (idade > 0 && idade < 18)
                Console.WriteLine($"Só {idade}? Você não pode beber, tem leitinho na geladeira!");
            else if (idade > 18 && idade < 99)
                Console.WriteLine($"{idade}!!!! Você pode beber! CERVEJARIA AMBEV!");
            else if (idade > 99)
                Console.WriteLine($"O QUE??!?!? {idade}.. tá véio P#$#@!!!! Melhor não beber mais...");
            else
                Console.WriteLine($" Não entendi");

            //ClearScreen();
            return idade;
        }

        /// <summary>
        /// Método para perguntar o nome
        /// </summary>
        /// <returns>retorna o nome informado</returns>
        private static string AskName()
        {
            Console.WriteLine("Qual o seu nome?");
            return Console.ReadLine();
        }
        

        /// <summary>
        /// Método para limpar a tela após 3 segundos (Thread.Sleep)
        /// </summary>
        private static void ClearScreen(int milisec)
        {
            Thread.Sleep(milisec);
            Console.Clear();
        }

    }
}
