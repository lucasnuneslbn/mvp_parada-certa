namespace ParadaCerta_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_avaliacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avaliacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Parceiro = c.Int(nullable: false),
                        Banheiro_Nota = c.Int(nullable: false),
                        Alimentacao_Nota = c.Int(nullable: false),
                        Seguranca_Nota = c.Int(nullable: false),
                        Banheiro_Avaliacao = c.String(),
                        Alimentacao_Avaliacao = c.String(),
                        Seguranca_Avaliacao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Avaliacaos");
        }
    }
}
