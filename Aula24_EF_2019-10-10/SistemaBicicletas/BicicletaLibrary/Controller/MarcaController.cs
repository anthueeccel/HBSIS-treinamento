using BicicletaLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Controller
{
    public class MarcaController
    {
        private BicicletaContext contextDb = new BicicletaContext();


        /// <summary>
        /// Método que retorna a lista de marcas
        /// </summary>
        /// <returns>IQuerable marcas ativas</returns>
        public IQueryable<Marca> GetMarcas()
        {
            return contextDb.Marcas.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Método que retorna marca por Id
        /// </summary>
        /// <returns>Objeto Marca</returns>
        public Marca GetMarca(Marca marca)
        {
            var marcaPorId = contextDb.Marcas.SingleOrDefault(x => x.Id == marca.Id);
            return marcaPorId;
        }

        /// <summary>
        /// Método que adiciona marca ao sistema (BD).
        /// </summary>
        /// <param name="marca"></param>
        public bool AddMarca(Marca marca)
        {
            if (marca != null)
            {
                contextDb.Marcas.Add(marca);
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Inativa (exclui) Marca do sistema
        /// </summary>
        /// <param name="Id"></param>
        public bool RemoverMarcaPorId(int id)
        {
            var marca = contextDb.Marcas.FirstOrDefault(x => x.Id == id);
            if (marca != null)
            {
                marca.Ativo = false;
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Método que atualiza os dados de uma Marca no sistema
        /// </summary>
        /// <param name="marcaUpdate">Dados da marca atualizados</param>
        /// <returns>Verdadeiro (atualizado) ou Falso (não atualizado)</returns>
        public bool UpdateMarca(Marca MarcaUpdate)
        {

            var result = contextDb.Marcas.FirstOrDefault(b => b.Id == MarcaUpdate.Id);
            if (result != null)
            {
                result.Id = MarcaUpdate.Id;
                result.Descricao = MarcaUpdate.Descricao;
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;

        }
    }
}
