namespace Aquarium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRUDoceansModelAquarium : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aquariums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aquariums");
        }
    }
}
