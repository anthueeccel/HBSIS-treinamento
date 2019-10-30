using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiBancoExistente.Controllers
{
    public partial class UsuariosController
    {

        [HttpGet]
        [Route("Api/Usuarios/CustonQuery")]
        public object CustomUsuariosQuery()
        {
            var listaDeObjetos = db.Usuarios.ToList();

            var retornoObjeto = from item in listaDeObjetos
                                select new { NomeUsuario = item.Usuario1, IdUsuario = item.Id };
            return retornoObjeto;
        }
    }
}