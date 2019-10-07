using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;
namespace EntityClass.Controller
{
    public class PessoaController
    {
        // Realiza conexão com o BD
        EntityContextDB contextDB = new EntityContextDB();

        // IQueryable : gera interface com a Classe. IQueryable tem várias funcionalidades 
        //para manipulação do banco de dados

        public IQueryable<Pessoa> GetPessoas()
        {
            return contextDB.ListaDePessoas;
        }

        /// <summary>
        /// Método que adiciona o objeto pessoa no BD
        /// </summary>
        /// <param name="pessoa">Pessoa</param>
        public void AddPessoa(Pessoa pessoa)
        {        
            contextDB.ListaDePessoas.Add(pessoa);
            contextDB.SaveChanges();
            
        }

    }
}
