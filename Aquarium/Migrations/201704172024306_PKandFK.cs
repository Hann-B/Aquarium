namespace Aquarium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PKandFK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarineLifeAquariums",
                c => new
                    {
                        MarineLife_Id = c.Int(nullable: false),
                        Aquariums_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MarineLife_Id, t.Aquariums_Id })
                .ForeignKey("dbo.MarineLives", t => t.MarineLife_Id, cascadeDelete: true)
                .ForeignKey("dbo.Aquariums", t => t.Aquariums_Id, cascadeDelete: true)
                .Index(t => t.MarineLife_Id)
                .Index(t => t.Aquariums_Id);
            
            CreateTable(
                "dbo.OceansMarineLives",
                c => new
                    {
                        Oceans_Id = c.Int(nullable: false),
                        MarineLife_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Oceans_Id, t.MarineLife_Id })
                .ForeignKey("dbo.Oceans", t => t.Oceans_Id, cascadeDelete: true)
                .ForeignKey("dbo.MarineLives", t => t.MarineLife_Id, cascadeDelete: true)
                .Index(t => t.Oceans_Id)
                .Index(t => t.MarineLife_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OceansMarineLives", "MarineLife_Id", "dbo.MarineLives");
            DropForeignKey("dbo.OceansMarineLives", "Oceans_Id", "dbo.Oceans");
            DropForeignKey("dbo.MarineLifeAquariums", "Aquariums_Id", "dbo.Aquariums");
            DropForeignKey("dbo.MarineLifeAquariums", "MarineLife_Id", "dbo.MarineLives");
            DropIndex("dbo.OceansMarineLives", new[] { "MarineLife_Id" });
            DropIndex("dbo.OceansMarineLives", new[] { "Oceans_Id" });
            DropIndex("dbo.MarineLifeAquariums", new[] { "Aquariums_Id" });
            DropIndex("dbo.MarineLifeAquariums", new[] { "MarineLife_Id" });
            DropTable("dbo.OceansMarineLives");
            DropTable("dbo.MarineLifeAquariums");
        }
    }
}
