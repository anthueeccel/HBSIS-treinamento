using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TraducaoRelatorios.Controllers
{
    public partial class VendasController
    {


        [HttpGet]
        [Route("Api/Vendas/PorAno/{ano}")]
        public object VendaAno(int ano)
        {
            var listaDeVendas = db.Vendas.ToList();
            var listaCarros = db.Carros.ToList();

            //List<object> listaObjetos = new List<object>();
            //foreach (var item in listaCarros)
            //{
            //    foreach (var itemVenda in item.Vendas)
            //    {
            //        listaObjetos.Add(new {
            //            batata = itemVenda.Carro,
            //            beterraba = item.Marca
            //        });
            //    }
            //}
            //Linq to Entity
            //EagerLoading
            //Laziloading
            var conteudoRetorno = from ven in listaDeVendas
                                  where ven.DatInc.Year == ano
                                  select new
                                  {
                                      vendaValor = ven.Valor,
                                      ano = ven.DatInc.Year,
                                  };                                  
                                    
            return conteudoRetorno;
        }


        [HttpGet]
        [Route("Api/Vendas/UsuarioPorAno/{ano}")]
        public object UsuarioVenda(int ano)
        {
            var listaDeVendas = db.Vendas.ToList();
            var listaDeUsuario = db.Usuarios.ToList();

            var conteudoRetorno = from ven in listaDeVendas
                                  join usu in listaDeUsuario
                                  on  ven.UsuInc equals usu.Id
                                  where ven.DatInc.Year == ano
                                  select new
                                  {
                                      usu.Usuario1,
                                      vendaValor = ven.Valor,
                                      ano = ven.DatInc.Year,
                                  };

            return conteudoRetorno;
        }


        [HttpGet]
        [Route("Api/VendasPorVendedor/Relatorio")]
        public object CustomVendasOnYear()
        {
            var listVendas = db.Vendas.ToList();
            var listUsuarios = db.Usuarios.ToList();

         


            var conteudoRetorno = from ven in listVendas
                                  join usu in listUsuarios
                                  on ven.UsuInc equals usu.Id
                                  group new { ven } by new { usu.Usuario1 ,ven.DatInc.Year, ven.UsuInc} into groupby
                                  select new
                                  {
                                      AnoVenda = groupby.Key.Year,
                                      Vendedor = groupby.Key.Usuario1,
                                      QtdeVendida = groupby.Sum(p => p.ven.Quantidade)

                                  };
            return conteudoRetorno;
        }


        [HttpGet]
        [Route("Api/Vendas/MarcaMais/{marca}")]
        public object MarcaMaisVendidaPorAno(string marca)
        {
            var listaDeVendas = db.Vendas.ToList();
            var listaDeMarcas = db.Marcas.ToList();
            var listaDeCarros = db.Carros.ToList();
            var listaDeUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from car in listaDeCarros
                                  join mar in listaDeMarcas
                                  on car.Marca equals mar.Id
                                  join ven in listaDeVendas
                                  on car.Id equals ven.Carro
                                  join usu in listaDeUsuarios
                                  on ven.UsuInc equals usu.Id
                                  
                                  where mar.Nome == marca                                  

                                  group new { ven } by new { usu.Usuario1, mar.Nome, ven.DatInc.Year, ven.UsuInc } into groupby
                                  select new
                                  {
                                      AnoVenda = groupby.Key.Year,
                                      Vendedor = groupby.Key.Usuario1,
                                      Marca = groupby.Key.Nome,
                                      QtdeVendida = groupby.Sum(p => p.ven.Quantidade)

                                  };





            return conteudoRetorno;
        }


    }
}
