using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ii = 30;
            Hebeficar(ref ii); //passa o parâmetro por referênci e precisa inicializar a variável
            Hebeficar2(out ii); // passa o parâmetro por referência sem precisar inicializar a variável
            int resultadoDaConversao = 0;
            int.TryParse("", out resultadoDaConversao);


            List<int> numeros = new List<int>();
            Random rdm = new Random();
            for (int w = 0; w < 10; w++)
            {
                // Gera um número aleatório de 0 a 100.
                int valorGeradoAleatoriamente = rdm.Next(100);
                //Verifica se a lista não contem o número gerado
                if (!numeros.Contains(valorGeradoAleatoriamente))
                {
                    //adiciona o número não repetido gerado na lista
                    numeros.Add(valorGeradoAleatoriamente);
                } else
                {
                    w--;
                }
            }



        }

        static void Hebeficar(ref int idade)
        {
            idade = 16000;
        }
        static void Hebeficar2(out int idade)
        {
            idade = 16000;
        }
    }
}
