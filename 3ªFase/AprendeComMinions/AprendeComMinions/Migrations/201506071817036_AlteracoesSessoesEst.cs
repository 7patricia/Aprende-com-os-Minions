namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracoesSessoesEst : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "Teste_TesteID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            AddColumn("dbo.SessaoEstudoes", "Teste_TesteID", c => c.Int());
            AddColumn("dbo.SessaoEstudoes", "Exercicio_ExercicioID", c => c.Int());
            AddColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            CreateIndex("dbo.SessaoEstudoes", "Teste_TesteID");
            CreateIndex("dbo.SessaoEstudoes", "Exercicio_ExercicioID");
            CreateIndex("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            AddForeignKey("dbo.SessaoEstudoes", "Teste_TesteID", "dbo.Testes", "TesteID");
            AddForeignKey("dbo.SessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes", "SessaoEstudoID");
            DropTable("dbo.TesteSessaoEstudoes");
            DropTable("dbo.ExercicioSessaoEstudoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ExercicioSessaoEstudoes",
                c => new
                    {
                        Exercicio_ExercicioID = c.Int(nullable: false),
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Exercicio_ExercicioID, t.SessaoEstudo_SessaoEstudoID });
            
            CreateTable(
                "dbo.TesteSessaoEstudoes",
                c => new
                    {
                        Teste_TesteID = c.Int(nullable: false),
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teste_TesteID, t.SessaoEstudo_SessaoEstudoID });
            
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.SessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.SessaoEstudoes", "Teste_TesteID", "dbo.Testes");
            DropIndex("dbo.Testes", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Testes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.Exercicios", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Exercicios", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.SessaoEstudoes", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.SessaoEstudoes", new[] { "Teste_TesteID" });
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.SessaoEstudoes", "Exercicio_ExercicioID");
            DropColumn("dbo.SessaoEstudoes", "Teste_TesteID");
            CreateIndex("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID");
            CreateIndex("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.TesteSessaoEstudoes", "Teste_TesteID");
            AddForeignKey("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID", cascadeDelete: true);
            AddForeignKey("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID", cascadeDelete: true);
            AddForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID", cascadeDelete: true);
            AddForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes", "TesteID", cascadeDelete: true);
        }
    }
}
