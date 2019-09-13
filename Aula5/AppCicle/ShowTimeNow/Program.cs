using System;
using System.Threading;

namespace ShowTimeNow
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Hora atual: {DateTime.Now.ToString("HH:mm:ss 'Blumenau,' dd 'de' MM 'de' yyy")}");
                Thread.Sleep(800);
                Console.Clear();
            }
        }
    }
}
