namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewAulas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UtilizadorAulas",
                c => new
                    {
                        Utilizador_UtilizadorID = c.Int(nullable: false),
                        Aula_AulaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Utilizador_UtilizadorID, t.Aula_AulaID })
                .ForeignKey("dbo.Utilizadors", t => t.Utilizador_UtilizadorID, cascadeDelete: true)
                .ForeignKey("dbo.Aulas", t => t.Aula_AulaID, cascadeDelete: true)
                .Index(t => t.Utilizador_UtilizadorID)
                .Index(t => t.Aula_AulaID);
            
            CreateTable(
                "dbo.UtilizadorExercicios",
                c => new
                    {
                        Utilizador_UtilizadorID = c.Int(nullable: false),
                        Exercicio_ExercicioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Utilizador_UtilizadorID, t.Exercicio_ExercicioID })
                .ForeignKey("dbo.Utilizadors", t => t.Utilizador_UtilizadorID, cascadeDelete: true)
                .ForeignKey("dbo.Exercicios", t => t.Exercicio_ExercicioID, cascadeDelete: true)
                .Index(t => t.Utilizador_UtilizadorID)
                .Index(t => t.Exercicio_ExercicioID);
            
            CreateTable(
                "dbo.UtilizadorTestes",
                c => new
                    {
                        Utilizador_UtilizadorID = c.Int(nullable: false),
                        Teste_TesteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Utilizador_UtilizadorID, t.Teste_TesteID })
                .ForeignKey("dbo.Utilizadors", t => t.Utilizador_UtilizadorID, cascadeDelete: true)
                .ForeignKey("dbo.Testes", t => t.Teste_TesteID, cascadeDelete: true)
                .Index(t => t.Utilizador_UtilizadorID)
                .Index(t => t.Teste_TesteID);
            
            AddColumn("dbo.Utilizadors", "Administrador", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UtilizadorTestes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.UtilizadorTestes", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.UtilizadorExercicios", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.UtilizadorAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.UtilizadorAulas", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropIndex("dbo.UtilizadorTestes", new[] { "Teste_TesteID" });
            DropIndex("dbo.UtilizadorTestes", new[] { "Utilizador_UtilizadorID" });
            DropIndex("dbo.UtilizadorExercicios", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.UtilizadorExercicios", new[] { "Utilizador_UtilizadorID" });
            DropIndex("dbo.UtilizadorAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.UtilizadorAulas", new[] { "Utilizador_UtilizadorID" });
            DropColumn("dbo.Utilizadors", "Administrador");
            DropTable("dbo.UtilizadorTestes");
            DropTable("dbo.UtilizadorExercicios");
            DropTable("dbo.UtilizadorAulas");
        }
    }
}
