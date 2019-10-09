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
        private LocacaoContext contextDb = new LocacaoContext();
        
      
        /// <summary>
        /// Método que lista os livros cadastrados no sistema
        /// </summary>
        /// <returns></returns>
        public List<Livro> GetLivros()
        {
            return contextDb.Livros.Where(c => c.Ativo == true).ToList();
        }
        /// <summary>
        /// Método que aicina em nossa lista já instanciada - no contrutor.
        /// </summary>
        /// <param name="livro">informações do livro que vamos adicionar</param>
        public void AddLivro(Livro livro)
        {           
            contextDb.Livros.Add(livro);
            contextDb.SaveChanges();
        }

        /// <summary>
        /// Método que remove/inativa o livro do sistema
        /// </summary>
        /// <param name="id">Id do livro</param>
        public void DeleteLivro(int id)
        {
            // FirstOrDefault retorna null caso não encontrar o livro.
            var livro = contextDb.Livros.FirstOrDefault(x => x.Id == id);
            if (livro != null)
                livro.Ativo = false;
            contextDb.SaveChanges();
        }

        /// <summary>
        /// Método que atualiza os dados de um Livro 
        /// </summary>
        /// <param name="LivroUpdate">Dados atualizados</param>
        /// <returns>Verdadeiro (atualizado) ou Falso (não atualizado)</returns>
        public bool UpdateLivro(Livro livroUpdate)
        {

            var result = contextDb.Livros.SingleOrDefault(b => b.Id == livroUpdate.Id);
            if (result != null)
            {
                result.Id = livroUpdate.Id;
                result.Nome = livroUpdate.Nome;
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;

        }


    }
}
