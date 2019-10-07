using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controller
{
    public class AlunoController
    {
        public ContextDB context = new ContextDB();
        public Aluno aluno = new Aluno();

        public Aluno GetAlunos(int id)
        {
            return context.Alunos.First(x => x.Id == id);
        }

        public IQueryable<Aluno> GetAlunos()
        {
            return context.Alunos;
        }

        public bool AddAluno(Aluno aluno)
        {
            try
            {
                context.Alunos.Add(aluno);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public void DelAluno(int id)
        {
            aluno = new Aluno();
            aluno.Id = id;
            context.Alunos.Remove(aluno);
            context.SaveChanges();

        }
    }
}
