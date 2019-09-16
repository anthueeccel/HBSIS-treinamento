using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");
            var seunome = Console.ReadLine();
            Console.WriteLine($"\r\nOlá {seunome}, bem vindo.\r\n");
            //ForeachComSplit();
            //ForeachComSplit1(seunome);
            //ContadorComRegex(seunome);
            //ForeachComSplitLista(seunome);
            ForeachComSplitLista2();


            Console.WriteLine("\n\n\r\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que mostra como podemos utilizar o foreach para andar sobre um array de caracteres, 
        /// ou seja um texto, palavra, etc.
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.Write("Informe o texto: ");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// Método que mostra como podemos utilizar o foreach e Split para andar sobre um array de caracteres, 
        /// ou seja um texto, palavra, etc e criar uma Collection
        /// </summary>
        private static void ForeachComSplit()
        {
            var conteudoDoTexto = "Aqui vou colocar meu nome Anthue para realizar a busca do meu nome Anthue";
            Console.WriteLine(conteudoDoTexto);
            Console.Write("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');
            var count = 0;

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    count++;
            }

            if (count > 0)
                Console.WriteLine($"Palavra '{palavra}' encontrada {count} vez(es) com sucesso.");

        }
        /// <summary>
        /// Método que mostra como podemos utilizar o foreach para andar sobre um array de caracteres, 
        /// ou seja um texto, palavra, etc, e criar uma Collection.
        /// </summary>
        private static void ForeachComSplit1(string seunome)
        {
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replace";
            Console.WriteLine(conteudoDoTexto);
            Console.Write("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');
            var count = 0;

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    count++;
            }
            if (count > 0)
                Console.WriteLine($"Palavra '{palavra}' encontrada {count} vez(es) com sucesso!");

        }
        /// <summary>
        /// Método que conta as palavras especificadas pelo usuário
        /// </summary>
        /// <param name="seunome"></param>
        private static void ContadorComRegex(string seunome)
        {
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replace";
            Console.WriteLine(conteudoDoTexto);
            Console.Write("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();
            Regex testeRegex = new Regex(palavra);
            Console.WriteLine($"Palavra '{palavra}' encontrada {testeRegex.Matches(conteudoDoTexto).Count.ToString()} vez(es)");

        }
        /// <summary>
        /// Método que lista os usuários do sistema e busca um usuário por nome
        /// </summary>
        private static void ForeachComSplitLista(string nomeBusca)
        {
            var conteudo = "nome:Anthue,idade:40;nome:Tiburcio,idade:75;nome:Eusebio,idade:29";

            var listaDeInformacaes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema:");

            foreach (var item in listaDeInformacaes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            foreach (var item in listaDeInformacaes)
            {
                var informacaoSplit = item.Split(',');
                var nome = informacaoSplit[0].Split(':')[1];
                var idade = informacaoSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} esta com {idade} anos de idade.");
                }

            }



        }
        /// <summary>
        /// Método que lista os carro do sistema e busca um carro por nome
        /// </summary>
        private static void ForeachComSplitLista2()
        {
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2000;carro:Hb20,marca:hyundai,ano:2015";

            var listaVeiculos = RetornaVeiculos(conteudo);
            ListarInformacoes(conteudo, listaVeiculos );

            Console.Write("Digite um carro, marca ou ano: ");
            var carroBusca = Console.ReadLine();
            BuscarInformacoes(carroBusca, listaVeiculos);           


        }
        /// <summary>
        /// Método que monta a lista baseada em um conteúdo arrays
        /// </summary>
        /// <param name="conteudo">array de string</param>
        /// <returns></returns>
        private static string[] RetornaVeiculos(string conteudo)
        {
            var listaDeInformacaes = conteudo.Split(';');
            return listaDeInformacaes;
        }
        /// <summary>
        /// Método que imprime na tela a lista de veículo no sistema
        /// </summary>
        /// <param name="conteudo">array de string[]</param>
        /// <param name="lista">lista de veículos</param>
        private static void ListarInformacoes(string conteudo, string[] lista)
        {

            Console.WriteLine("Carros cadastrados no sistema:");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

        }
        /// <summary>
        /// Método que busca o veículo solicitado pelo usuário
        /// </summary>
        /// <param name="carroBusca">busca veículo </param>
        /// <param name="lista">lista de veículos no sistema</param>
        private static string[] BuscarInformacoes(string carroBusca, string[] lista)
        {
            foreach (string item in lista)
            {
                var informacaoSplit = item.Split(',');
                var carro = informacaoSplit[0].Split(':')[1];
                var marca = informacaoSplit[1].Split(':')[1];
                var ano = informacaoSplit[2].Split(':')[1];
                if (carro == carroBusca || marca == carroBusca || ano == carroBusca)
                    Console.WriteLine($"Resultado: carro: {carro}, marca: {marca}, ano: {ano}.");

            }
            return lista;

        }
    }
}
