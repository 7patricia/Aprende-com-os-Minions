namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDAtribUtilizador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SessoesEstudo", "Utilizador_UtilizadorID", c => c.Int());
            CreateIndex("dbo.SessoesEstudo", "Utilizador_UtilizadorID");
            AddForeignKey("dbo.SessoesEstudo", "Utilizador_UtilizadorID", "dbo.Utilizadors", "UtilizadorID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessoesEstudo", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropIndex("dbo.SessoesEstudo", new[] { "Utilizador_UtilizadorID" });
            DropColumn("dbo.SessoesEstudo", "Utilizador_UtilizadorID");
        }
    }
}
