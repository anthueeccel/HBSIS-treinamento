using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblicoteca;

namespace AcessandoDllDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaBiblicoteca.MyFuckingTree.StupidTree();
            MinhaBiblicoteca.ListaDeMarcas.ClasseListaCarros();
            MinhaBiblicoteca.ListaDeMarcas.ClasseListaCervejas();

            var calculo = new MinhaBiblicoteca.CalculoDeArea();
            Console.Write("Lado do quadrado: ");
            int lado = int.Parse(Console.ReadLine());
            Console.WriteLine($"Área do quadrado: {calculo.CalculaAreaQuad(lado)}");
            Console.ReadKey();
        }
    }
}
