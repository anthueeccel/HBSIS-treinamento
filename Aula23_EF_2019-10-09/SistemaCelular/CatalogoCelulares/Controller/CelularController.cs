using CatalogoCelulares.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Controller
{
    public class CelularController
    {
        CelularesContextDB contextDb = new CelularesContextDB();

        /// <summary>
        /// Returna a lista de celular do sistema
        /// </summary>
        /// <returns>collection de celulares</returns>
        public IQueryable<Celular> GetCelulares()
        {

            return contextDb.Celulares
                .Where(c => c.Ativo); //por padrão == true
        }

        /// <summary>
        /// Método que atualiza os dados de um celular 
        /// </summary>
        /// <param name="celularAlterado">Dados atualizados</param>
        /// <returns>Verdadeiro (atualizado) ou Falso (não atualizado)</returns>
        public bool UpdateCelular(Celular celularAlterado)
        {

            var result = contextDb.Celulares.SingleOrDefault(b => b.Id == celularAlterado.Id);
            if (result != null)
            {
                result.Id = celularAlterado.Id;
                result.Marca = celularAlterado.Marca;
                result.Modelo = celularAlterado.Modelo;
                result.Preco = celularAlterado.Preco;
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// Método que inclui um celular no sistema
        /// </summary>
        /// <param name="celular">objeto celular</param>
        public bool AddCelular(Celular celular)
        {
            if (string.IsNullOrWhiteSpace(celular.Marca))
                return false;

            if (string.IsNullOrWhiteSpace(celular.Modelo))
                return false;

            if (celular.Preco <= 0)
                return false;


            celular.DataInclusao = DateTime.Now;
            contextDb.Celulares.Add(celular);
            contextDb.SaveChanges();
            return true;
        }


        /// <summary>
        /// Método que altera o Status de Ativo para inativo no sistema 
        /// </summary>
        /// <param name="id">Id para destativar</param>
        /// <returns>Verdadeiro em caso de sucesso</returns>
        public bool DeleteCelular(int id)
        {
            if (id.Equals("") || id.Equals(null))
                return false;

            var celular = contextDb.Celulares.FirstOrDefault(x => x.Id == id);
            if (celular.Equals(null))
                return false;

            celular.Ativo = false;
            contextDb.SaveChanges();
            return true;
        }

    }
}
