namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatesTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Perguntas", "URLImagem", c => c.String());
            AddColumn("dbo.Utilizadors", "NrPerguntasResp", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Utilizadors", "NrPerguntasResp");
            DropColumn("dbo.Perguntas", "URLImagem");
        }
    }
}
