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

            var listaDePessoas = pessoaController.ListaDePessoasPublic;

            ImprimeTag("Lista Original");
            listaDePessoas
                .OrderBy(o => o.Id).ToList<Pessoa>()
                .ForEach(c => ImprimeDados(c));

            ImprimeTag("Lista Ordem por Nome");
            pessoaController.GetPessoasOrdenadaAscendente()
                .ForEach(c => ImprimeDados(c));

            ImprimeTag("Lista Ordem por Data de Nascimento");
            pessoaController.GetPessoasOrdenadasDescDtNasc()
                .ForEach(c => ImprimeDados(c));

            ImprimeTag($"Lista Pessoas > R${500}");
            //(from dinheiroCarteira in listaDePessoas
            // where dinheiroCarteira.Carteira > 500
            // select dinheiroCarteira).ToList<Pessoa>()

            //Console.WriteLine("Valor: ");
            //double valor = 0;
            //double.TryParse(Console.ReadLine(), out valor);

            pessoaController.GetPessoasCarteiraMaior500()
             .ForEach(c => ImprimeDados(c));


            ImprimeTag($"Lista Pessoas > {18} anos");
            pessoaController.RetornaListaPorIdadeMaior18(18)
                .ForEach(c => ImprimeDados(c));

            ImprimeTag($"Lista Pessoas < {16} anos");
            pessoaController.RetornaListaPorIdadeMenor16()
                .ForEach(c => ImprimeDados(c));

            Console.WriteLine("Filtro para idade maior ou menor");
            Console.WriteLine("Filtro para idade: ");
            int idade;
            int.TryParse(Console.ReadLine(), out idade);
            pessoaController.getPessoasPorIdadeMaiorOuMenor(idade)
                .ForEach(c => ImprimeDados(c));

            Console.ReadKey();
        }

        /// <summary>
        /// Método para imprimir no console os dados da Classe Pessoa.
        /// </summary>
        /// <param name="pessoa"></param>
        public static void ImprimeDados(Pessoa pessoa)
        {
            string template = "Id: {0,-3} | Nome: {1,-10} | Data Nascimento: {2,10} | Carteira: {3,8}";
            string textoFormatado = string.Format(template,
                pessoa.Id,
                pessoa.Nome,
                pessoa.DateNascimento.ToShortDateString(),
                pessoa.Carteira.ToString("C2"));
            Console.WriteLine(textoFormatado);
        }

        /// <summary>
        /// Método que imprime o nome da ação executada (listagem)
        /// </summary>
        /// <param name="nomeMetodo">Identificador da Listagem</param>
        public static void ImprimeTag(string nomeMetodo)
        {
            Console.WriteLine(string.Format("\n======================== {0,0} =======================", nomeMetodo));
        }
    }
}
