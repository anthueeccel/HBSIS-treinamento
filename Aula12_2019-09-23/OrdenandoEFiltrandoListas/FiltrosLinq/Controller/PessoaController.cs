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

        private List<Pessoa> ListaDePessoas { get; set; }
        //public List<Pessoa> listaPessoas = new List<Pessoa>();

        // Consturtor da classe
        public PessoaController()
        {
            ListaDePessoas = CarregaLista();
        }


        /// <summary>
        /// Carrega a lista de pessoas de um arquivo txt separados por ";"
        /// </summary>
        /// <returns>listaDePessoas</returns>
        private List<Pessoa> CarregaLista()
        {
            //Instância da lista que será preenchida
            //var listaDePessoas = new List<Pessoa>();
            ListaDePessoas = new List<Pessoa>();

            //Retorna todas as linhas do arquivo em um array
            //de string, onde cada linha será um índice do array
            string[] array = File.ReadAllLines(@"C:\temp\listaPessoas.txt");

            //percorre o array e para cada linha
            for (int i = 0; i < array.Length; i++)
            {
                //cria um objeto do tipo Pessoa
                Pessoa c = new Pessoa();

                //Split para 'quebrar' as linhas da Array em um Array auxiliar 
                //do arquivo txt carregado, separando por ';'. Cada índice 
                // representa uma propriedade da Classe
                string[] auxiliar = array[i].Split(';');

                // Preencher os dados da Array nas propriedades da Classe
                // na List<Pessoa>
                c.Id = Convert.ToInt32(auxiliar[0]);
                c.Nome = auxiliar[1];
                c.DateNascimento = DateTime.Parse(auxiliar[2]);
                c.Carteira = double.Parse(auxiliar[3]);

                ListaDePessoas.Add(c);

            }
            return ListaDePessoas;
        }


        // Cria uma lista List<Pessoa> pública que pdoe ser apenas acessada 'get', 
        // assim não permite-se que a lista seja alterada
        public List<Pessoa> ListaDePessoasPublic
        {
            get { return ListaDePessoas; }
        }

        /// <summary>
        /// Método que retorna lista de pessoas ordenada pelo nome
        /// de A-Z (Ascendente).
        /// </summary>
        /// <returns>Lista de Pessoas</returns>
        public List<Pessoa> GetPessoasOrdenadaAscendente()
        {
            return ListaDePessoas
                .OrderBy(x => x.Nome)
                .ToList<Pessoa>();
        }

        /// <summary>
        /// Método que retorna lista de pessoas ordenadas descedente por 
        /// data de nascimento.
        /// </summary>
        /// <returns>lista de Pessoa</returns>
        public List<Pessoa> GetPessoasOrdenadasDescDtNasc()
        {
            return ListaDePessoas
                .OrderByDescending(x => x.DateNascimento)
                .ToList<Pessoa>();
        }
        /// <summary>
        /// Método que retorna lista de pessoas com mais de 500 na carteira
        /// </summary>
        /// <param name="valor">Valor informado para o filtro.
        /// Caso não informe valor, o padrão será 500</param>
        /// <returns>Lista de pessoas</returns>
        public List<Pessoa> GetPessoasCarteiraMaior500(double valor = 500)
        {
            return ListaDePessoas
                .FindAll(c => c.Carteira > valor)
                .OrderBy(c => c.Carteira).ToList<Pessoa>();
        }

        /// <summary>
        /// Método que retorna uma lista com pessoas maiores de 18 anos ou valor informado
        /// </summary>
        /// <returns>listaPessoas com idade maior que a informada, ou por padrão >18</returns>
        public List<Pessoa> RetornaListaPorIdadeMaior18(int idade = 18)
        {
            return ListaDePessoas
                .FindAll(x => (DateTime.Now.Year - x.DateNascimento.Year) >= idade);
        }

        /// <summary>
        /// Método que retornar uma lista com pessoas menos de 16 anos
        /// </summary>
        /// <returns>listaPessoas</returns>
        public List<Pessoa> RetornaListaPorIdadeMenor16()
        {
            return ListaDePessoas.FindAll(x => (DateTime.Now.Year - x.DateNascimento.Year) <= 16);
        }

        public List<Pessoa> getPessoasPorIdadeMaiorOuMenor(int idade = 17)
        {
            if (idade >= 18)
            {
                return ListaDePessoas
                    .FindAll(x => (DateTime.Now.Year - x.DateNascimento.Year) >= idade);
            }
            else
            {
                return ListaDePessoas
                    .FindAll(x => (DateTime.Now.Year - x.DateNascimento.Year) <= idade);
            }
        }
    }
}
