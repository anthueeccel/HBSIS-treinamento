namespace BikeshopApp.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bicicleta
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Descricao { get; set; }

        public int? ModeloId { get; set; }

        public bool? Ativo { get; set; }

        public int? userInclusao { get; set; }

        public int? userAlteracao { get; set; }

        public DateTime? dataInclusao { get; set; }

        public DateTime? dataAlteracao { get; set; }

        [JsonIgnore]
        public virtual Modelo Modelo { get; set; }
    }
}
