using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrosLinq.Controller
{
    class PessoaController
    {
        public List<Pessoa> listaPessoas = new List<Pessoa>();
        public Pessoa pessoa = new Pessoa();

     /// <summary>
     /// Carrega a lista de pessoas de um arquivo txt separados por ";"
     /// </summary>
     /// <returns>listaDePessoas</returns>
        public List<Pessoa> CarregaLista()
        {
            var listaDePessoas = new List<Pessoa>();
            //Instância da lista que será preenchida

            //Retorna todas as linhas do arquivo em um array
            //de string, onde cada linha será um índice do array
            string[] array = File.ReadAllLines(@"C:\temp\listaPessoas.txt");

            //percorro o array e para cada linha
            for (int i = 0; i < array.Length; i++)
            {
                //crio um objeto do tipo Pessoa
                Pessoa c = new Pessoa();

                //Uso o método Split e quebro cada linha
                //em um novo array auxiliar, ou seja, cada
                //conteúdo do arquivo txt separado por ';' será
                //um nova linha neste array auxiliar. Assim sei que
                //cada índice representa uma propriedade
                string[] auxiliar = array[i].Split(';');

                //Aqui recupero os itens, atribuindo
                //os mesmo as propriedade da classe
                //Pessoa correspondentes, ou seja,
                //o índice zero será corresponde ao Id                
                c.Id = Convert.ToInt32(auxiliar[0]);
                c.Nome = auxiliar[1];
                c.DateNascimento = DateTime.Parse(auxiliar[2]);
                c.Carteira = double.Parse(auxiliar[3]);
                
                //Adiciono o objeto a lista
                listaDePessoas.Add(c);

            }
            return listaDePessoas;
        }

        /// <summary>
        /// Método que retornar uma lista com pessoas maiores de 18 anos
        /// </summary>
        /// <returns>listaPessoas</returns>
        public List<Pessoa> RetornaListaPorIdadeMaior18()
        {
            return listaPessoas.FindAll(x => (DateTime.Now.Year - x.DateNascimento.Year) >= 18);
        }

        /// <summary>
        /// Método que retornar uma lista com pessoas menos de 16 anos
        /// </summary>
        /// <returns>listaPessoas</returns>
        public List<Pessoa> RetornaListaPorIdadeMenor16()
        {
            return listaPessoas.FindAll(x => (DateTime.Now.Year - x.DateNascimento.Year) <= 16);
        }


    }
}
