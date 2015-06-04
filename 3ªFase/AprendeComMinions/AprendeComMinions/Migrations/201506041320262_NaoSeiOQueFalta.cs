namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NaoSeiOQueFalta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aulas", "URLImagem", c => c.String());
            AddColumn("dbo.Aulas", "URLVideo", c => c.String());
            AddColumn("dbo.Exercicios", "URLImagem", c => c.String());
            AddColumn("dbo.Utilizadors", "UtilLigado", c => c.Int(nullable: false));
            DropColumn("dbo.Aulas", "URL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aulas", "URL", c => c.String());
            DropColumn("dbo.Utilizadors", "UtilLigado");
            DropColumn("dbo.Exercicios", "URLImagem");
            DropColumn("dbo.Aulas", "URLVideo");
            DropColumn("dbo.Aulas", "URLImagem");
        }
    }
}
