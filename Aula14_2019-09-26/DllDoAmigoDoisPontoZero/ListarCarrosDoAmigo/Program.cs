using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
            static CarroController controller = new CarroController();
        static void Main(string[] args)
        {
            ImprimeListaCarro();
            Console.ReadKey();
        }

        public static void ImprimeListaCarro()
        {
            controller.GetCarros().ForEach(x => Console.WriteLine($"Marca {x.Marca} Modelo {x.Modelo} Ano {x.Ano} Cilindradas {x.Cilindradas} Portas {x.Portas}"));

        }
    }
}
