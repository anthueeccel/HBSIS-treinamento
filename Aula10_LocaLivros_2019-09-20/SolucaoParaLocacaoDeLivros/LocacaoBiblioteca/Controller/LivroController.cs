using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os métdos para manipulação dos dados 
    /// </summary>
    public class LivroController
    {
        private LocacaoContext contextDB = new LocacaoContext();
        
        /// <summary>
        /// Construtor da Classe Livro
        /// </summary>
        ///<param name="lista">Lista de livros</param>
        public LivroController()
        {

        }


        /// <summary>
        /// Método que lista os livros cadastrados no sistema
        /// </summary>
        /// <returns></returns>
        public List<Livro> ListarLivros()
        {
            return contextDB.ListaDeLivros.Where(c => c.Ativo == true).ToList();
        }
        /// <summary>
        /// Método que aicina em nossa lista já instanciada - no contrutor.
        /// </summary>
        /// <param name="livro">informações do livro que vamos adicionar</param>
        public void AdicionaLivro(Livro livro)
        {
            livro.Id = contextDB.idContadorLivro++;
            contextDB.ListaDeLivros.Add(livro);
        }

        /// <summary>
        /// Método que remove/inativa o livro do sistema
        /// </summary>
        /// <param name="id">Id do livro</param>
        public void RemoverLivroPorId(int id)
        {
            // FirstOrDefault retorna null caso não encontrar o livro.
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == id);
            if (livro != null)
                livro.Ativo = false;
        }






        // List carregada no Context
        /// <summary>
        /// Popula a lista de livros no sistema
        /// </summary>
        //public void PopulaListaLivros()
        //{
        //    //Popula a lista de livros
        //    contextDB.ListaDeLivros = new List<Livro>();

        //    contextDB.ListaDeLivros.Add(
        //   new Livro()
        //   {
        //       Id = contextDB.idContadorLivro++,
        //       Nome = "Use a Cabeça C#",
        //       Ativo = true
        //   });
        //    contextDB.ListaDeLivros.Add(
        //    new Livro()
        //    {
        //        Id = +contextDB.idContadorLivro++,
        //        Nome = "Use a Cabeça SQL",
        //        Ativo = true
        //    });
        //    contextDB.ListaDeLivros.Add(
        //    new Livro()
        //    {
        //        Id = contextDB.idContadorLivro++,
        //        Nome = "Guia do Mochileiro das Galáxias",
        //        Ativo = true
        //    });
        //    contextDB.ListaDeLivros.Add(
        //    new Livro()
        //    {
        //        Id = contextDB.idContadorLivro++,
        //        Nome = "Aprendendo Lógica de Programação",
        //        Ativo = true
        //    });
        //}
    }
}
