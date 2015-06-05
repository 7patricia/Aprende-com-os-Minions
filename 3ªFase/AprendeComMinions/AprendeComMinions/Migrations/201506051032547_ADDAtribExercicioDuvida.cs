namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDAtribExercicioDuvida : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropPrimaryKey("dbo.Exercicios");
            AlterColumn("dbo.Exercicios", "ExercicioID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Exercicios", "ExercicioID");
            CreateIndex("dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.Exercicios", "ExercicioID", "dbo.Duvidas", "DuvidaID");
            AddForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID", cascadeDelete: true);
            AddForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Exercicios", "ExercicioID", "dbo.Duvidas");
            DropIndex("dbo.Exercicios", new[] { "ExercicioID" });
            DropPrimaryKey("dbo.Exercicios");
            AlterColumn("dbo.Exercicios", "ExercicioID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID", cascadeDelete: true);
        }
    }
}
