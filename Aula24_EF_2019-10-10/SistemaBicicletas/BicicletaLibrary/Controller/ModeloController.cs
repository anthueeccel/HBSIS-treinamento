using BicicletaLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Controller
{
    public class ModeloController
    {
        private BicicletaContext contextDb = new BicicletaContext();


        /// <summary>
        /// Métoo que retorna a lista dos bicicletas
        /// </summary>
        /// <returns>IQuerable bicicletas ativas</returns>
        public IQueryable<Modelo> GetModelos()
        {
             return contextDb.Modelos.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Método que retorna bicicleta por Id
        /// </summary>
        /// <returns>Objeto Bicicleta</returns>
        public Modelo GetModelo(Modelo modelo)
        {
            return contextDb.Modelos.SingleOrDefault(x => x.Id == modelo.Id);
        }

        /// <summary>
        /// Método que adiciona bicicleta ao sistema (BD).
        /// </summary>
        /// <param name="modelo"></param>
        public bool AddModelo(Modelo modelo)
        {
            if (modelo != null)
            {
                contextDb.Modelos.Add(modelo);
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
        public bool RemoverModeloPorId(int id)
        {
            var bicicleta = contextDb.Modelos.FirstOrDefault(x => x.Id == id);
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
        /// Método que atualiza os dados de uma Modelo no sistema
        /// </summary>
        /// <param name="ModeloUpdate">Dados atualizados</param>
        /// <returns>Verdadeiro (atualizado) ou Falso (não atualizado)</returns>
        public bool UpdateModelo(Modelo modeloUpdate)
        {

            var result = contextDb.Modelos.FirstOrDefault(b => b.Id == modeloUpdate.Id);
            if (result != null)
            {
                result.Id = modeloUpdate.Id;
                result.Descricao = modeloUpdate.Descricao;
                result.MarcaId = modeloUpdate.MarcaId;
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;

        }
    }
}
