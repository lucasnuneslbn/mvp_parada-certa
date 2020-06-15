namespace ParadaCerta_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_PArc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parceiros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Pessoa = c.Int(nullable: false),
                        Id_Credencial = c.Int(nullable: false),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        SERV_Abast = c.Boolean(nullable: false),
                        SERV_Med = c.Boolean(nullable: false),
                        SERV_Psico = c.Boolean(nullable: false),
                        SERV_Odonto = c.Boolean(nullable: false),
                        SERV_Borracharia = c.Boolean(nullable: false),
                        SERV_Funilaria = c.Boolean(nullable: false),
                        SERV_Refeicoes = c.Boolean(nullable: false),
                        SERV_Mecan = c.Boolean(nullable: false),
                        FL_ALoj = c.Boolean(nullable: false),
                        FL_Desc = c.Boolean(nullable: false),
                        FL_Conv = c.Boolean(nullable: false),
                        FL_Ducha = c.Boolean(nullable: false),
                        FL_Estac = c.Boolean(nullable: false),
                        FL_Vest = c.Boolean(nullable: false),
                        FL_Wifi = c.Boolean(nullable: false),
                        BRD_Bone = c.Boolean(nullable: false),
                        BRD_Luva = c.Boolean(nullable: false),
                        BRD_Bota = c.Boolean(nullable: false),
                        BRD_Cuia = c.Boolean(nullable: false),
                        BRD_Frigideira = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parceiros");
        }
    }
}
