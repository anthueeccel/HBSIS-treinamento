using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public int idContadorCerveja = 1;
        public SistemaCervejaContext()
        {
            ListaDeCervejasPrivada = new List<Cerveja>();
            ListaDeCervejasPrivada.Add(new Cerveja() { Id = idContadorCerveja++, Nome = "Brahma Extra", Litros = 0.355, Alcool = 5.2, Valor = 2.98  });
            ListaDeCervejasPrivada.Add(new Cerveja() { Id = idContadorCerveja++, Nome = "Corona", Litros = 0.350, Alcool = 5.4, Valor = 3.66  });
            ListaDeCervejasPrivada.Add(new Cerveja() { Id = idContadorCerveja++, Nome = "Stella Artois", Litros = 0.550, Alcool = 5.0, Valor = 6.74  });
            ListaDeCervejasPrivada.Add(new Cerveja() { Id = idContadorCerveja++, Nome = "Bohemia", Litros = 0.355, Alcool = 5.2, Valor = 2.87  });
            ListaDeCervejasPrivada.Add(new Cerveja() { Id = idContadorCerveja++, Nome = "Budweiser", Litros = 0.355, Alcool = 4.9, Valor = 2.75  });



        }
        private List<Cerveja> ListaDeCervejasPrivada { get; set; }

        public List<Cerveja> ListaDeCervejas { get { return ListaDeCervejasPrivada; } }
    }

}
