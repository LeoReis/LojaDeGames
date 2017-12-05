namespace LojaDeGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tafunfando : DbMigration
    {
        public override void Up()
        {

            
            CreateTable(
                "dbo.VideoGs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Marca = c.String(),
                    })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Consoles", "MarcaType_Id", "dbo.MarcaTypes");
            DropIndex("dbo.Consoles", new[] { "MarcaType_Id" });
            DropColumn("dbo.Consoles", "MarcaType_Id");
            DropColumn("dbo.Consoles", "MarcaTypeId");
            DropTable("dbo.VideoGs");
            DropTable("dbo.MarcaTypes");
        }
    }
}
