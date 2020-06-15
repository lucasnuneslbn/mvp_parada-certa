namespace ParadaCerta_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class at_bool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Parceiros", "SERV_Abast", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Med", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Psico", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Odonto", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Borracharia", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Funilaria", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Refeicoes", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Mecan", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_ALoj", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Desc", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Conv", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Ducha", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Estac", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Vest", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Wifi", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Bone", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Luva", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Bota", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Cuia", c => c.Int(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Frigideira", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Parceiros", "BRD_Frigideira", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Cuia", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Bota", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Luva", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "BRD_Bone", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Wifi", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Vest", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Estac", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Ducha", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Conv", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_Desc", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "FL_ALoj", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Mecan", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Refeicoes", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Funilaria", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Borracharia", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Odonto", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Psico", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Med", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Parceiros", "SERV_Abast", c => c.Boolean(nullable: false));
        }
    }
}
