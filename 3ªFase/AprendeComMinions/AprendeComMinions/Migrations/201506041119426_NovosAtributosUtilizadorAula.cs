namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovosAtributosUtilizadorAula : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Respostas", "RespostaCerta_RespostaID", "dbo.Respostas");
            DropIndex("dbo.Respostas", new[] { "RespostaCerta_RespostaID" });
            AddColumn("dbo.Aulas", "Titulo", c => c.String());
            AddColumn("dbo.Aulas", "URL", c => c.String());
            AddColumn("dbo.Perguntas", "RespCerta", c => c.String());
            AddColumn("dbo.Respostas", "RespA", c => c.Int(nullable: false));
            AddColumn("dbo.Respostas", "RespB", c => c.Int(nullable: false));
            AddColumn("dbo.Respostas", "RespC", c => c.Int(nullable: false));
            DropColumn("dbo.Respostas", "RespostaCerta_RespostaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Respostas", "RespostaCerta_RespostaID", c => c.Int());
            DropColumn("dbo.Respostas", "RespC");
            DropColumn("dbo.Respostas", "RespB");
            DropColumn("dbo.Respostas", "RespA");
            DropColumn("dbo.Perguntas", "RespCerta");
            DropColumn("dbo.Aulas", "URL");
            DropColumn("dbo.Aulas", "Titulo");
            CreateIndex("dbo.Respostas", "RespostaCerta_RespostaID");
            AddForeignKey("dbo.Respostas", "RespostaCerta_RespostaID", "dbo.Respostas", "RespostaID");
        }
    }
}
