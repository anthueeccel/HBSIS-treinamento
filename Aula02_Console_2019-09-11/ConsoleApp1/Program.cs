using System;

/// <summary>
/// Criado por: Anthue
/// Data: 2019-09-10
/// </summary>

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Texto informativo para consultar o livro pelo número do registro do sistema
            Console.WriteLine("Infrome o livro a ser consultado: ");
            //Parte do codigo que recebe as informações do registro do livro e coloca na variável numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();


            if (numeroDoLivro == "123456")
            {
                Console.WriteLine("Livro inddisponível!!!!");
                Console.ReadKey();
                //Finaliza o método
                return;
            }
            else
            {
                Console.WriteLine("Deseja locar o livro ? (1) Sim (2) Não ");
                var resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.WriteLine("Livro locado.");
                    Console.ReadKey();
                    return;
                }
            }

        }
    }
}
