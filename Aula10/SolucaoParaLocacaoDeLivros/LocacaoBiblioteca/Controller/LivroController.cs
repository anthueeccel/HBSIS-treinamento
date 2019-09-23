using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivroController
    {
        private int idContador = 0;

        //public List<Livro> listaLivros = new List<Livro>(); //substituído pela propriedade acima.
        private List<Livro> ListaDeLivros { get; set; }

        /// <summary>
        /// Construtor da Classe Livro
        /// </summary>
        public LivroController()
        {
           
        }


        /// <summary>
        /// Método que lista os livros cadastrados no sistema
        /// </summary>
        /// <returns></returns>
        public List<Livro> ListarLivros()
        {
            return ListaDeLivros;
        }
        /// <summary>
        /// Método que aicina em nossa lista já instanciada - no contrutor.
        /// </summary>
        /// <param name="livro">informações do livro que vamos adicionar</param>
        public void AdicionaLivro(Livro livro)
        {
            livro.Id = ++idContador;
            ListaDeLivros.Add(livro);
        }

        /// <summary>
        /// Popula a lista de livros no sistema
        /// </summary>
       public void PopulaListaLivros()
        {
            //Popula a lista de livros
            ListaDeLivros = new List<Livro>();

            ListaDeLivros.Add(
           new Livro()
           {
               Id = ++idContador,
               Nome = "Use a Cabeça C#",
               Ativo = true
           });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = ++idContador,
                Nome = "Use a Cabeça SQL",
                Ativo = true
            });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = ++idContador,
                Nome = "Guia do Mochileiro das Galáxias",
                Ativo = true
            });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = ++idContador,
                Nome = "Aprendendo Lógica de Programação",
                Ativo = true
            });
        }
    }
}
