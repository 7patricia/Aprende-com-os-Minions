namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Testes",
                c => new
                    {
                        TesteID = c.Int(nullable: false, identity: true),
                        DataRealizacao = c.DateTime(nullable: false),
                        Classificacao = c.Single(nullable: false),
                        Tema = c.String(),
                    })
                .PrimaryKey(t => t.TesteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testes");
        }
    }
}
