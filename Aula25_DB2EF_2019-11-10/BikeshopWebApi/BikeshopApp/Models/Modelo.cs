namespace BikeshopApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Modelos")]
    public partial class Modelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modelo()
        {
            Bicicletas = new HashSet<Bicicleta>();
        }

        public int Id { get; set; }

        [StringLength(30)]
        public string Descricao { get; set; }

        public int? MarcaId { get; set; }

        public bool? Ativo { get; set; }

        public int? userInclusao { get; set; }

        public int? userAlteracao { get; set; }

        public DateTime? dataInclusao { get; set; }

        public DateTime? dataAlteracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bicicleta> Bicicletas { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
