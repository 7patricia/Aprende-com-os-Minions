namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTabelasdjkcndskjcs : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Exercicios", "Cotacao");
            DropColumn("dbo.Perguntas", "Cotacao");
            DropColumn("dbo.Testes", "Cotacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Testes", "Cotacao", c => c.Single(nullable: false));
            AddColumn("dbo.Perguntas", "Cotacao", c => c.Single(nullable: false));
            AddColumn("dbo.Exercicios", "Cotacao", c => c.Single(nullable: false));
        }
    }
}
