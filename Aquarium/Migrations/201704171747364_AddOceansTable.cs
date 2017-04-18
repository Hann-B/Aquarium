namespace Aquarium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOceansTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Oceans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AvgTemp = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Oceans");
        }
    }
}
