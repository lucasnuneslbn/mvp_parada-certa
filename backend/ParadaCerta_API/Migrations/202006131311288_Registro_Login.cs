namespace ParadaCerta_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registro_Login : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistroLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(),
                        Senha = c.String(),
                        Session = c.String(),
                        DataLogin = c.DateTime(nullable: false),
                        Successful = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegistroLogins");
        }
    }
}
