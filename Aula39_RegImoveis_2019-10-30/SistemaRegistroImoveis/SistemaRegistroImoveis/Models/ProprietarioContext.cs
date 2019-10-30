namespace SistemaRegistroImoveis.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProprietarioContext : DbContext
    {
        // Your context has been configured to use a 'ProprietarioContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SistemaRegistroImoveis.Models.ProprietarioContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ProprietarioContext' 
        // connection string in the application configuration file.
        public ProprietarioContext()
            : base("name=ProprietarioContext")
        {
        }

        //public System.Data.Entity.DbSet<SistemaRegistroImoveis.Models.Proprietario> Proprietarios { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Proprietario> Proprietarios { get; set; }

        public System.Data.Entity.DbSet<SistemaRegistroImoveis.Models.Imovel> Imovels { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}