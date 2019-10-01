using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaCarros();
        }
        
        private static void ConsultaCarros()
        {
            //Base de informações
            var conteudo = "nome:Anthue,idade:40;nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            ListarInformacoesPorNome(conteudo);

            Console.WriteLine("Digite o nome para a busca:");
            var nomeUsuario = Console.ReadLine();

            var pessoaSelecionada = RetornaUsuario(conteudo, nomeUsuario);

            Console.WriteLine(string.Format("Usuario: {0} tem {1}",
                ObterValor(pessoaSelecionada, "nome"),
                ObterValor(pessoaSelecionada, "idade")));

            Console.ReadKey();
        }

        private static void ListarInformacoesPorNome(string conteudo)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');
                var nomeUsuario = separandoInformacoes[0].Split(':')[1];
                var idadeUsuario = int.Parse(separandoInformacoes[1]. Split(':')[1]);
                if(idadeUsuario >= 18)
                Console.WriteLine($"Nome do usuário: {nomeUsuario}, idade: {idadeUsuario}");
            }
        }

        private static string[] RetornaUsuario(string conteudo, string nomeDoUsuario)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');

                var nomeUsuario = ObterValor(separandoInformacoes, "nome");
                var verificaIdade = Convert.ToInt32(ObterValor(separandoInformacoes, "idade"));

                if (nomeUsuario == nomeDoUsuario && verificaIdade >= 18)
                    return separandoInformacoes;
                
            }

            return new string[0];
        }
        private static string ObterValor(string[] colecao, string tipo)
        {
            foreach (var item in colecao)
            {
                var quebrandoInformacao = item.Split(':');

                if (quebrandoInformacao[0] == tipo)
                    return quebrandoInformacao[1];
            }

            return string.Empty;
        }
    }
}
