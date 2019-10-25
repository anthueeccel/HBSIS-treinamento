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
    public class CalculoIdadeController : ApiController
    {
        
            /// <summary>
            /// retorna o nome de nossa aplicação
            /// </summary>
            /// <returns>retorna o que nosso app faz</returns>
            public string Get()
        {
            return "App para beber hoje";
        }


        public string Get(int anoNascimento, string nomeUsuario = "Default")
        {
            var idade = DateTime.Now.Year - anoNascimento;

            if(idade < 18)
            return $"Olá {nomeUsuario} Bb pode beber NÃO";
            else 
                return $"Então {nomeUsuario} pode beber sim, Bb!";
        }      

    }
}
