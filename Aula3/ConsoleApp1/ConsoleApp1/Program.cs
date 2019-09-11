using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        // iniciando uma constante de um número inteiro
        const int testeConst = 999;

        struct Pessoa
        {
            public string nome;
            public string documento;
        }

        static void Main(string[] args)
        {
            ////Teste de tipo struc
            //Pessoa pessoa = new Pessoa();
            //pessoa.nome = "João";
            //pessoa.documento = "123456";                                

            //Console.WriteLine($@" Nome: {pessoa.nome}, documento: {pessoa.documento}");
            //Console.WriteLine(testeConst);

            Objeto objeto = new Objeto();
            objeto.nomeObjeto = "Luminária 2 lâmpadas";
            objeto.tipoObjeto = "Lustre";
            Console.WriteLine($"Produto: {objeto.nomeObjeto}, tipo {objeto.tipoObjeto} "  );




            //int x = 0;
            //int y = 0;
            //int z = 0;
            //var resposta = String.Empty;

            //Console.WriteLine("Digite o valor de x: ");
            //resposta = Console.ReadLine();
            //if (resposta.Equals("") || resposta.Equals(null))
            //    x = 0;
            //else
            //    x = Convert.ToInt32(resposta);

            //Console.WriteLine("Digite o valor de y: ");
            //resposta = Console.ReadLine();
            //if (resposta.Equals("") || resposta.Equals(null))
            //    y = 0;
            //else
            //    y = Convert.ToInt32(resposta);

            //Console.WriteLine("Digite o valor de z: ");
            //resposta = Console.ReadLine();
            //z = 0;
            //if (resposta.Equals("") || resposta.Equals(null))
            //    z = 0;
            //else
            //    z = Convert.ToInt32(resposta);

            ////Cálculos
            //if (x > 0)
            //{
            //    Console.WriteLine($@"A área do quadrado (lado x) é de: {x * 2}m²");
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine($@"A área do triângulo equilátero (lado x, altura y) é de: {(x * y) / 2}m²");
            //        Console.WriteLine($@"A área do retângulo (lado x e lado y) é de: {(x * y)}m²");
            //        if (x > 0 && y > 0 && z > 0)
            //            Console.WriteLine($@"A área do triângulo (x*y)/z é de: {(x * y) / z}m²");
            //    }
            //}
            //else
            //    Console.WriteLine("Sem cálculos");


            Console.ReadKey();
        }
    }
}
