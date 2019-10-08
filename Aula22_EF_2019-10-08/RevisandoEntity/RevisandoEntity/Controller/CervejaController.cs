using RevisandoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Controller
{

    public class CervejaController
    {
        private CervejaContextDB context = new CervejaContextDB();

        public void AddCerveja(Cerveja cerveja)
        {
            if (cerveja.Nome.Contains("Cerveja"))
            {
                context.Cervejas.Add(cerveja);
                context.SaveChanges();
            }

        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return context.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}
