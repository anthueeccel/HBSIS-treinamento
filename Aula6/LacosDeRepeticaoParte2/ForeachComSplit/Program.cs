using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachComSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            var conteudo = "nome:Anthue,idade:40;nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            var conteudoEmLista = ConverteConteudoEmLista(conteudo);

            ImprimeLista(conteudoEmLista);

            Console.Write("PROCURAR: informe nome: ");
            var buscaPessoa = Console.ReadLine();
            var pessoa = BuscaPessoa(buscaPessoa, conteudoEmLista);

            foreach (var item in pessoa)
            {
            Console.WriteLine(item);

            }

            Console.ReadKey();

        }

        private static string BuscaPessoa(string buscaPessoa, string[] conteudoEmLista)
        {
            
            foreach (var item in conteudoEmLista)
            {
                var pessoa = item.Split(':')[0];

                if (pessoa == buscaPessoa && item[1] > 18)
                    return pessoa;
            }

            return string.Empty ;
        }

        private static string[] ConverteConteudoEmLista(string conteudo)
        {
            var converteConteudoEmLista = conteudo.Split(';');

            return converteConteudoEmLista;
        }
        private static void ImprimeLista(string[] conteudoEmLista)
        {
            foreach (var item in conteudoEmLista)
            {
                var nome = conteudoEmLista[0].Split(',');
                var idade = conteudoEmLista[1].Split(',');
                Console.WriteLine($"Nome: {nome} e idade: {idade}");
            }
        }
    }
}
