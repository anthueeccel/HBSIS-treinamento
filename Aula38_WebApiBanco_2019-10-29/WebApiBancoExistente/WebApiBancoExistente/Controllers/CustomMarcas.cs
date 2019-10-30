using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiBancoExistente.Controllers
{
    public partial class MarcasController
    {

        [HttpGet]
        [Route("Api/Usuarios/CustonQuery")]
        public object CustomMarcasQuery()
        {
            var listaDeObjetos = db.Marcas.ToList();

            var retornoObjeto = from item in listaDeObjetos
                                select new { NomeMarca = item.Nome, IdMarca = item.Id };
            return retornoObjeto;
        }


    }
}