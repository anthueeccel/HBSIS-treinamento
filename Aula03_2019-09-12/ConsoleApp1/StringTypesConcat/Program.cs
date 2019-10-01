using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTypesConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = @"alguma coisa mais alguma informação aqui";
            Console.WriteLine(teste);

            

            var testeTemplate = @"Nome do usuário: {0}
Idade: {1}
Descrição: {2}";

            var finishText = string.Format(testeTemplate
                ,Console.ReadLine()
                ,Console.ReadLine()
                ,Console.ReadLine());

            Console.WriteLine(finishText);


            Console.ReadKey();

        }
    }
}
