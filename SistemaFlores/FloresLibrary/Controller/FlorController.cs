using FloresLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloresLibrary.Controller
{
    public class FlorController
    {
        public FlorContextDb contextDb = new FlorContextDb();
        public Flor flor = new Flor();

        public IQueryable<Flor> GetFlores()
        {
            return contextDb.Flores;
        }

        public bool AddFlor(Flor flor)
        {
            if (flor != null)
            {
                contextDb.Flores.Add(flor);
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;
        }


    }
}
