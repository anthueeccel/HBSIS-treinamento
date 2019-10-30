using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarroesController
    {
        [HttpGet]
        [Route("Api/Carroes/CustonQuery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from carros in listaDeCarros
                                select new { NomeCarro = carros.Modelo, IdCarro = carros.Id };
            return retornoCarros;
        }

        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
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
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome
                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("api/Carroes/{id}/CarroUsuario")]
        public object CustonCarrosOnUsuario(int id)
        {
            var listaDeCarros = db.Carros.ToList();
            var listadeUsuarios = db.Usuarios.ToList();

            var retornaObjeto = from usu in listadeUsuarios
                                join car in listaDeCarros
                                on usu.Id equals car.UsuInc
                                where car.Id == id
                                select new
                                {
                                    usu.Usuario1
                                };
            return retornaObjeto;
        }




    }
}