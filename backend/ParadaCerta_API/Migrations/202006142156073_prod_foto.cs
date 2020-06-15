namespace ParadaCerta_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prod_foto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "Foto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "Foto");
        }
    }
}
