using ListagemDeCervejas.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCerveja
{
    public class LeiSeca
    {
        public static  CervejaController cervejaController = new CervejaController();
        public static void TesteAlcool()
        {
            var lista = cervejaController.GetCervejas();

            Console.Write("Qual o seu peso? ");
            double weight = double.Parse(Console.ReadLine()) * 0.453592;
            Console.Write("Sexo (M/F): ");
            String gender = Console.ReadLine().ToLower();
            Console.Write("Esta bebendo faz quantas horas? ");
            double time = double.Parse(Console.ReadLine());
            Console.Write("Quantos tipos/variedade de cerveja você bebeu? ");
            Console.WriteLine(lista.Count.ToString());
            int numDrinks = lista.Count();
            double i = 0;
            double bac = 0;
            double currentBAC = 0;
            double widmark = (gender.Equals('f') ? 0.55 : 0.68); //Quoeficiente relativo ao sexo



            double volume = 0;
            double abv = 0;
            while ((i < numDrinks))
            {
                lista.ForEach(x =>
                {
                    volume += (x.Litros*1000) / 29.5735; //converte mililitros para ounces
                    abv += x.Alcool / 100; // percentual de álcool
                });

                bac = (bac
                            + ((volume
                            * (abv * 5.14))
                            / (weight * widmark)));
                i++;
            }

            currentBAC = (bac - (0.015 * time)); //diminuição do percentual de álcool no sangue por hora.
            if ((currentBAC >= 0))
            {
                Console.WriteLine(("Sua graduação alcóolia é provavelmente " + currentBAC.ToString("N3")));
            }
            else
            {
                Console.WriteLine("Sua graduação alcóolica deve estar normal");
            }

        }



    }
}
