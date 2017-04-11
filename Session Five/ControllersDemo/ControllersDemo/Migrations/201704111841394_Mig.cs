namespace ControllersDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.artists",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        artistname = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.artists");
        }
    }
}
