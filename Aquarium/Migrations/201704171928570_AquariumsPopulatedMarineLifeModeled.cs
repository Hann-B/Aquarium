namespace Aquarium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AquariumsPopulatedMarineLifeModeled : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarineLives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Color = c.String(),
                        Name = c.String(),
                        DateAddedToTank = c.DateTime(nullable: false),
                        IsInQuarenteen = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MarineLives");
        }
    }
}
