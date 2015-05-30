namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSessaoEstudo2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            CreateTable(
                "dbo.SessaoEstudoAulas",
                c => new
                    {
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                        Aula_AulaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SessaoEstudo_SessaoEstudoID, t.Aula_AulaID })
                .ForeignKey("dbo.SessoesEstudo", t => t.SessaoEstudo_SessaoEstudoID, cascadeDelete: true)
                .ForeignKey("dbo.Aulas", t => t.Aula_AulaID, cascadeDelete: true)
                .Index(t => t.SessaoEstudo_SessaoEstudoID)
                .Index(t => t.Aula_AulaID);
            
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            DropForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.SessaoEstudoAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropTable("dbo.SessaoEstudoAulas");
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
        }
    }
}
