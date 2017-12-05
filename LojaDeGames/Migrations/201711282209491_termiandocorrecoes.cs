namespace LojaDeGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class termiandocorrecoes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VideoGs", "Nome", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.VideoGs", "Marca", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VideoGs", "Marca", c => c.String());
            AlterColumn("dbo.VideoGs", "Nome", c => c.String());
        }
    }
}
