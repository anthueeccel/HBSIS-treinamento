using NomesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesLibrary.Controller
{
    public class NomeController
    {
        NomesContextDb contextDb = new NomesContextDb();

        public IQueryable<Nome> GetNomes()
        {
            return contextDb.Nomes;
        }

        public bool AddNome(Nome nome)
        {
            if (nome != null)
            {
                contextDb.Nomes.Add(nome);
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;
        }
        
    }
}
