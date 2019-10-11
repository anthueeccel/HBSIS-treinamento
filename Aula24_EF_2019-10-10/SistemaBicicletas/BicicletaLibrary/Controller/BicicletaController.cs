using BicicletaLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Controller
{
    public class BicicletaController
    {
        private BicicletaContext contextDb = new BicicletaContext();


        /// <summary>
        /// Métoo que retorna a lista dos bicicletas
        /// </summary>
        /// <returns>IQuerable bicicletas ativas</returns>
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contextDb.Bicicletas.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Método que retorna bicicleta por Id
        /// </summary>
        /// <returns>Objeto Bicicleta</returns>
        public Bicicleta GetBicicleta(Bicicleta bicicleta)
        {
            var bicicletaPorId = contextDb.Bicicletas.SingleOrDefault(x => x.Id == bicicleta.Id);
            return bicicletaPorId;
        }

        /// <summary>
        /// Método que adiciona bicicleta ao sistema (BD).
        /// </summary>
        /// <param name="bicicleta"></param>
        public bool AddBicicleta(Bicicleta bicicleta)
        {
            if (bicicleta != null)
            {
                contextDb.Bicicletas.Add(bicicleta);
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Inativa (exclui) bicicleta do sistema
        /// </summary>
        /// <param name="Id"></param>
        public bool RemoverBicicletaPorId(int id)
        {
            var bicicleta = contextDb.Bicicletas.FirstOrDefault(x => x.Id == id);
            if (bicicleta != null)
            {
                bicicleta.Ativo = false;
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Método que atualiza os dados de uma Bicicleta no sistema
        /// </summary>
        /// <param name="BicicletaUpdate">Dados atualizados</param>
        /// <returns>Verdadeiro (atualizado) ou Falso (não atualizado)</returns>
        public bool UpdateBicicleta(Bicicleta bicicletaUpdate)
        {

            var result = contextDb.Bicicletas.FirstOrDefault(b => b.Id == bicicletaUpdate.Id);
            if (result != null)
            {
                result.Id = bicicletaUpdate.Id;
                result.Descricao = bicicletaUpdate.Descricao;
                result.ModeloId = bicicletaUpdate.ModeloId;
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;

        }

    }
}
