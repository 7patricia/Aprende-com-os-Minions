namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateExercicio : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exercicios", "ExercicioID", "dbo.Duvidas");
            DropForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.SessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropIndex("dbo.Exercicios", new[] { "ExercicioID" });
            DropPrimaryKey("dbo.Exercicios");
            AddColumn("dbo.Exercicios", "DuvidaURL", c => c.String());
            AlterColumn("dbo.Exercicios", "ExercicioID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID", cascadeDelete: true);
            AddForeignKey("dbo.SessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            DropTable("dbo.Duvidas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Duvidas",
                c => new
                    {
                        DuvidaID = c.Int(nullable: false, identity: true),
                        URLVideo = c.String(),
                    })
                .PrimaryKey(t => t.DuvidaID);
            
            DropForeignKey("dbo.SessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropPrimaryKey("dbo.Exercicios");
            AlterColumn("dbo.Exercicios", "ExercicioID", c => c.Int(nullable: false));
            DropColumn("dbo.Exercicios", "DuvidaURL");
            AddPrimaryKey("dbo.Exercicios", "ExercicioID");
            CreateIndex("dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.SessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID", cascadeDelete: true);
            AddForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.Exercicios", "ExercicioID", "dbo.Duvidas", "DuvidaID");
        }
    }
}
