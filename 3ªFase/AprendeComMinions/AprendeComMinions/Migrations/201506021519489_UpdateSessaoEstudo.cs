namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSessaoEstudo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SessoesEstudo", "Tema", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SessoesEstudo", "Tema");
        }
    }
}
