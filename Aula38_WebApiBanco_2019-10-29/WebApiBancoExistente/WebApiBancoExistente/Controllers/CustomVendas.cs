using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiBancoExistente.Controllers
{
    public partial class VendasController
    {

        [HttpGet]
        [Route("Api/Usuarios/CustonQuery")]
        public object CustomVendasQuery()
        {
            var listaDeObjetos = db.Vendas.ToList();

            var retornoObjeto = from item in listaDeObjetos
                                select new { NomeVendas = item.Carro1, IdVendas = item.Id };
            return retornoObjeto;
        }
    }
}