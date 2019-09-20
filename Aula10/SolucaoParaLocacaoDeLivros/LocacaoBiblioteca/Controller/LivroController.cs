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
        /// <summary>
        /// Construtor da Classe Livro
        /// </summary>
        public LivroController()
        {
            ListaDeLivros = new List<Livro>();

            //Popula a lista de livros
            ListaDeLivros.Add(
           new Livro()
           {
               Id = 001,
               Nome = "Use a Cabeça C#",
               Ativo = true
           });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = 002,
                Nome = "Use a Cabeça SQL",
                Ativo = true
            });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = 003,
                Nome = "Guia do Mochileiro das Galáxias",
                Ativo = true
            });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = 004,
                Nome = "Aprendendo Lógica de Programação",
                Ativo = true
            });


        }

        
        public List<Livro> ListaDeLivros { get; set; }
        

        //public List<Livro> listaLivros = new List<Livro>();
        /// <summary>
        /// Método que lista os livros cadastrados no sistema
        /// </summary>
        /// <returns></returns>
        public List<Livro> ListarLivros()
        {
            return ListaDeLivros;
        }

        public void AdicionaLivro()
        {
            throw new NotImplementedException();
        }
    }
}
