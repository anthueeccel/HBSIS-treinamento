using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TreeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Frame1();
            Console.ReadKey();
        }
        /// <summary>
        /// Método que desenha uma árvore estática no console
        /// </summary>
        public static void ArvoreNoConsole()
        {
            Console.Clear();
            Console.WriteLine("    @@@@");
            Console.WriteLine("  @@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@");
            Console.WriteLine("    @@@");
            Console.WriteLine("    @@@");
            Console.WriteLine("    @@@");
        }
        /// <summary>
        /// Método que imprime uma animação de uma árvore no console
        /// </summary>
        public static void Frame1()
        {
            Console.Clear();
            string[] frame1 = File.ReadAllLines(@"C:\temp\Frame1.txt");
            string[] frame2 = File.ReadAllLines(@"C:\temp\Frame2.txt");
            string[] frame3 = File.ReadAllLines(@"C:\temp\Frame3.txt");
            string[] frame4 = File.ReadAllLines(@"C:\temp\Frame4.txt");

            int opcao = 0;
            while (opcao < 20)
            {
                opcao++;
                foreach (var item in frame1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Frame {opcao++} de 20");
                Thread.Sleep(80);
                Console.Clear();
                foreach (var item in frame2)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Frame {opcao++} de 20");
                Thread.Sleep(80);
                Console.Clear();
                foreach (var item in frame3)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Frame {opcao++} de 20");
                Thread.Sleep(80);
                Console.Clear();
                foreach (var item in frame4)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Frame {opcao++} de 20");
                Thread.Sleep(80);
                Console.Clear();
            }



        }

    }
}
