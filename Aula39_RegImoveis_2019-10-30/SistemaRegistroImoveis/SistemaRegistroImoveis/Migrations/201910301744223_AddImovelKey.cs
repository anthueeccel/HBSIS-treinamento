namespace SistemaRegistroImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImovelKey : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Imovels", "Cep", c => c.String(maxLength: 9));
            AlterColumn("dbo.Imovels", "Logradouro", c => c.String(maxLength: 50));
            AlterColumn("dbo.Imovels", "Bairro", c => c.String(maxLength: 30));
            AlterColumn("dbo.Imovels", "Complemento", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Imovels", "Complemento", c => c.String());
            AlterColumn("dbo.Imovels", "Bairro", c => c.String());
            AlterColumn("dbo.Imovels", "Logradouro", c => c.String());
            AlterColumn("dbo.Imovels", "Cep", c => c.String());
        }
    }
}
