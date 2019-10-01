using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        // inicializa o contador do Id
        public readonly int contadorIdCarro = 1;

        //Construtor da classe
        public SistemaCarrosContext()
        {
            ListaDeCarrosPrivada = new List<Carro>();

            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Ford", Modelo = "Ka", Ano = 2015, Cilindradas = 1000, Portas = 3 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Chevrolet", Modelo = "Monza SL/E", Ano = 2002, Cilindradas = 2000, Portas = 5 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Ford", Modelo = "Fusion", Ano = 2018, Cilindradas = 3000, Portas = 4 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Fiat", Modelo = "Palio", Ano = 2013, Cilindradas = 1400, Portas = 3 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Volkswagen", Modelo = "Polo", Ano = 2009, Cilindradas = 1600, Portas = 3 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Ford", Modelo = "Ka Sedan", Ano = 2019, Cilindradas = 1000, Portas = 4 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Renault", Modelo = "Fluence", Ano = 2017, Cilindradas = 1800, Portas = 4 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Peugeot", Modelo = "306", Ano = 2010, Cilindradas = 1600, Portas = 5 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Ford", Modelo = "Ka", Ano = 2015, Cilindradas = 1000, Portas = 3 });
            ListaDeCarrosPrivada.Add(new Carro(){Id = contadorIdCarro++, Marca = "Porsche", Modelo = "911 Turbo", Ano = 2000, Cilindradas = 3500, Portas = 2 });
            
        }

        public List<Carro> ListaDeCarros { get { return ListaDeCarrosPrivada; }  }
        private List<Carro>ListaDeCarrosPrivada { get; set; }

    }
}
