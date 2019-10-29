using SolucaoPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SolucaoPessoas.Controllers
{
    public class PessoaController : ApiController
    {
        List<Pessoa> listaDePessoas = new List<Pessoa>()
        {
        new Pessoa{ Nome="Pessoa 1", Idade = 40 },
        new Pessoa{ Nome="A Pessoa 2", Idade = 20 },
        new Pessoa{ Nome="Seu Pessoa 3", Idade = 34 },
        new Pessoa{ Nome="Tia Pessoa 4", Idade = 44 },
        new Pessoa{ Nome="Lady Pessoa 5", Idade = 43 },
        new Pessoa{ Nome="Dona Pessoa 6", Idade = 63 },

        };        

        public List<Pessoa> Get()
        {
            return listaDePessoas;
        }

        public bool Post(Pessoa pessoa)
        {
            listaDePessoas.Add(pessoa);
            return true;
        }

    }
}
