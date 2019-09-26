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
        static void Main(string[] args)
        {
            CarroController controller = new CarroController();

            controller.GetCarros().ForEach(x => Console.WriteLine($"Marca {x.Marca} Modelo {x.Modelo} Ano {x.Ano} Cilindradas {x.Cilindradas} Portas {x.Portas}"));
            Console.ReadKey();
        }
    }
}
