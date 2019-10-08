using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Controller;
using CodeFirstTeste.Model;

namespace VisualizarCerveja
{
    class Program
    {
        static CervejaController controller = new CervejaController();
        static void Main(string[] args)
        {
            Cerveja cerveja = new Cerveja { Nome = "Cerveja Nova cerveja", Teor = 5.4, Tipo = "Pilsen" };
            controller.AddCerveja(cerveja);

            controller.GetCervejas().ToList().ForEach(c => Console.WriteLine(c.Nome));


            Console.ReadKey();
        }
    }
}
