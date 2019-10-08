using CodeFirstTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {

        const string conexao = @"data source=(localdb)\MSSQLlocalDB;initial catalog=RevisandoEntity.Model.
                                    CervejaContextDB;integrated security=True;MultipleActiveResultSets=True;
                                    App=EntityFramework";

        CervejaContextDb contextDb = new CervejaContextDb(conexao);

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDb.Cervejas;
        }

        public void AddCerveja(Cerveja cerveja)
        {
            contextDb.Cervejas.Add(cerveja);
            contextDb.SaveChanges();
        }

    }
}
