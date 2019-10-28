using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolucaoPessoas.Models
{
    public class PessoaContext
    {

        public List<Pessoa> pessoas = new List<Pessoa>() {

        new Pessoa() { Nome = "Anthue", Idade = 40},
        new Pessoa() { Nome = "Pessoa 1", Idade = 30},
        new Pessoa() { Nome = "Pessoa 2", Idade = 20},
        new Pessoa() { Nome = "Pessoa 3", Idade = 30},
        new Pessoa() { Nome = "Pessoa 4", Idade = 32},
        new Pessoa() { Nome = "Pessoa 5", Idade = 18},
        new Pessoa() { Nome = "Pessoa 6", Idade = 34},
        new Pessoa() { Nome = "Pessoa 7", Idade = 44},
        new Pessoa() { Nome = "Pessoa 8", Idade = 65},
        new Pessoa() { Nome = "Pessoa 9", Idade = 67}

        };
    }
}