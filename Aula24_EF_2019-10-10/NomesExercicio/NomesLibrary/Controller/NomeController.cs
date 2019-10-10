using NomesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesLibrary.Controller
{
    class NomeController
    {
        NomesContextDb contextDb = new NomesContextDb();

        public IQueryable<Nome> GetNomes()
        {
            return contextDb.Nomes;
        }


    }
}
