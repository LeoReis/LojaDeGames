namespace LojaDeGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jogoes", "Nome", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Jogoes", "Genero", c => c.String(nullable: false));
            AlterColumn("dbo.Jogoes", "FaixaEtaria", c => c.String(nullable: false));
            AlterColumn("dbo.Jogoes", "Desenvolvedora", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jogoes", "Desenvolvedora", c => c.String());
            AlterColumn("dbo.Jogoes", "FaixaEtaria", c => c.String());
            AlterColumn("dbo.Jogoes", "Genero", c => c.String());
            AlterColumn("dbo.Jogoes", "Nome", c => c.String());
        }
    }
}
