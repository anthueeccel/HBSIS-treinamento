using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TraducaoRelatorios.Controllers
{
    public partial class CarroesController
    {

        [HttpGet]
        [Route("Api/Carroes/NomeMarca")]
        public object NomeMarca()
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listaDeMarcas
                                  join car in listaDeCarros
                                  on mar.Id equals car.Marca
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaNome = mar.Nome
                                  };
            return conteudoRetorno;
        }


    }
}
