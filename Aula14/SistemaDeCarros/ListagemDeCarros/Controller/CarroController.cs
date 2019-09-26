using ListagemDeCarros.Model;
using System.Collections.Generic;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
       
        private SistemaCarrosContext carrosContext = new SistemaCarrosContext();


        /// <summary>
        /// Método que retorna a lita de carros.
        /// </summary>
        /// <returns>lista de carros List</returns>
        public List<Carro> GetCarros()
        {
            return carrosContext.ListaDeCarros;
        }
    }
}
