using CalculandoIdade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIdade.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ImcController : ApiController
    {

        List<Pessoa> pessoas = new List<Pessoa>();


        [HttpGet]
        public string Get(double peso, double altura, string nome = "Default")
        {
            var imc = peso / (altura * altura);

            return $"Olá {nome} de acordo com sua Altura:{altura} e Peso:{peso} seu IMC é: {Math.Round(imc, 1)}";

        }

        [HttpGet]
        public List<Pessoa> Get()
        {
            return pessoas;
        }


        [HttpPost]
        public Pessoa Post(Pessoa pessoa)
        {
            var imcValue = new ObjectImc();
            var novaPessoa = new Pessoa();
            novaPessoa = pessoa;


            imcValue.ImcValue = pessoa.Peso / (pessoa.Altura * pessoa.Altura);
            //novaPessoa.ImcValue.ImcValue = pessoa.Peso / (pessoa.Altura * pessoa.Altura);

            novaPessoa.ImcValue = new ObjectImc();
            novaPessoa.ImcValue.ImcValue = imcValue.ImcValue;
            pessoas.Add(novaPessoa);

            return novaPessoa;
            //return $"Olá {pessoa.Nome} de acordo com sua Altura:{pessoa.Altura} e Peso:{pessoa.Peso} seu IMC é: {Math.Round(imc,1)}";
        }

    }
}
