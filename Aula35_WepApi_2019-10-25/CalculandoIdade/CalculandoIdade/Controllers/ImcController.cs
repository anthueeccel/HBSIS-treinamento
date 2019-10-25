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
        public string Get(double peso, double altura, string nome = "Default")
        {
            var imc = peso / (altura * altura);
                       
            return $"Olá {nome} seu IMC é {imc} e ele foi calculado de acordo com sua Altura:{altura} e Peso:{peso}";

        }
    }
}
