namespace BikeshopApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BikeShopContext : DbContext
    {
        public BikeShopContext()
            : base("name=BikeShopContext")
        {
        }

        public virtual DbSet<Bicicleta> Bicicletas { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Modelo> Modelos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
