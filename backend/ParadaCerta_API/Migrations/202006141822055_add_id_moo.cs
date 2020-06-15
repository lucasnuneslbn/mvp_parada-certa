namespace ParadaCerta_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_id_moo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Avaliacaos", "Id_Motorista", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Avaliacaos", "Id_Motorista");
        }
    }
}
