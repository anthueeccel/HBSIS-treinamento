using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Código para trabalhar com Array, Matriz, Lista
/// </summary>

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[3] { "Felipe", "Giomar", "Tiburcio" };
            //arrayLinear[0] = "Felipe";
            //arrayLinear[1] = "Giomar";
            //arrayLinear[2] = "Tiburcio";


            List<string> listaLinear = new List<string>
            {
                "Felipe",
                "Giomar",
                "Tiburcio"
            };


            List<string> listaLinear2 = new List<string>();
            listaLinear.Add("Felipe");
            listaLinear.Add("Giomar");
            listaLinear.Add("Tiburcio");

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listaLinear[0]);
            var keypress = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine(keypress);
            Console.ReadKey();
        }
    }
}
