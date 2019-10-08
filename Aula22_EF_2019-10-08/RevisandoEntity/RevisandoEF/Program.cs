using RevisandoEntity.Controller;
using RevisandoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEF
{
    class Program
    {
        private static CervejaController controller = new CervejaController();
        private static Cerveja cerveja = new Cerveja();

        static void Main(string[] args)
        {

            cerveja.Nome = "Cerveja Skol";
            cerveja.Teor = 5.6;
            cerveja.Tipo = "Pilsen";
            controller.AddCerveja(cerveja);

            Console.WriteLine("Lista de Cervejas no Banco de Dados");

            string template = "|{0,3} | {1,-50} | {2,-20} | {3,3}|";

            controller.GetCervejas().ToList().ForEach(c => Console.WriteLine(String.Format(template, c.Id, c.Nome, c.Tipo, c.Teor)));

            Console.ReadKey();

        }
    }
}
