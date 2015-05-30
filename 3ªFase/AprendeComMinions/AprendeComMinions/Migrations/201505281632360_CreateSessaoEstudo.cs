namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSessaoEstudo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SessoesEstudo",
                c => new
                    {
                        SessaoEstudoID = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Tema = c.String(),
                    })
                .PrimaryKey(t => t.SessaoEstudoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SessoesEstudo");
        }
    }
}
