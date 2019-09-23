using FiltrosLinq.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrosLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaController pessoaController = new PessoaController();

            var listaDePessoas = pessoaController.CarregaLista();

            Console.WriteLine("\n-----------------Lista Original");
            listaDePessoas
                .OrderBy(o => o.Id).ToList<Pessoa>()
                .ForEach(c => Console.WriteLine($"Id: {c.Id}| Nome: {c.Nome}| Data Nascimento: {c.DateNascimento.ToShortDateString()}| Carteira: R${c.Carteira}"));

            Console.WriteLine("\n-----------------Lista Ordem por Nome");
            listaDePessoas.OrderBy(h => h.Nome).ToList<Pessoa>()
                .ForEach(c => Console.WriteLine($"Id: {c.Id}| Nome: {c.Nome}| Data Nascimento: {c.DateNascimento.ToShortDateString()}| Carteira: R${c.Carteira}"));

            Console.WriteLine("\n-----------------Lista Ordem por Data de Nascimento");
            listaDePessoas.OrderByDescending(h => h.DateNascimento).ToList<Pessoa>()
                .ForEach(c => Console.WriteLine($"Id: {c.Id}| Nome: {c.Nome}| Data Nascimento: {c.DateNascimento.ToShortDateString()}| Carteira: R${c.Carteira}"));

            Console.WriteLine("\n-----------------Lista Pessoas > R$500");
            (from dinheiroCarteira in listaDePessoas
             where dinheiroCarteira.Carteira > 500
             select dinheiroCarteira).ToList<Pessoa>()
                .ForEach(c => Console.WriteLine($"Id: {c.Id}| Nome: {c.Nome}| Data Nascimento: {c.DateNascimento.ToShortDateString()}| Carteira: R${c.Carteira}"));

            Console.WriteLine("\n-----------------Lista Pessoas > 18 anos");
            pessoaController.RetornaListaPorIdadeMaior18()
                .ForEach(c => Console.WriteLine($"Id: {c.Id}| Nome: {c.Nome}| Data Nascimento: {c.DateNascimento.ToShortDateString()}| Carteira: R${c.Carteira}"));


            Console.WriteLine("\n-----------------Lista Pessoas < 16 anos");
            pessoaController.RetornaListaPorIdadeMenor16()
                             .ForEach(c => Console.WriteLine($"Id: {c.Id}| Nome: {c.Nome}| Data Nascimento: {c.DateNascimento.ToShortDateString()}| Carteira: R${c.Carteira}"));







            Console.ReadKey();
        }
    }
}
