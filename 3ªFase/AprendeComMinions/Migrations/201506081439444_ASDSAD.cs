namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ASDSAD : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Testes", "Pergunta_PerguntaID", "dbo.Perguntas");
            DropIndex("dbo.Perguntas", new[] { "Teste_TesteID1" });
            DropIndex("dbo.Testes", new[] { "Pergunta_PerguntaID" });
            DropColumn("dbo.Perguntas", "Teste_TesteID");
            RenameColumn(table: "dbo.Perguntas", name: "Teste_TesteID1", newName: "Teste_TesteID");
            DropColumn("dbo.Testes", "DataRealizacao");
            DropColumn("dbo.Testes", "Classificacao");
            DropColumn("dbo.Testes", "Pergunta_PerguntaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Testes", "Pergunta_PerguntaID", c => c.Int());
            AddColumn("dbo.Testes", "Classificacao", c => c.Single(nullable: false));
            AddColumn("dbo.Testes", "DataRealizacao", c => c.DateTime(nullable: false));
            RenameColumn(table: "dbo.Perguntas", name: "Teste_TesteID", newName: "Teste_TesteID1");
            AddColumn("dbo.Perguntas", "Teste_TesteID", c => c.Int());
            CreateIndex("dbo.Testes", "Pergunta_PerguntaID");
            CreateIndex("dbo.Perguntas", "Teste_TesteID1");
            AddForeignKey("dbo.Testes", "Pergunta_PerguntaID", "dbo.Perguntas", "PerguntaID");
        }
    }
}
