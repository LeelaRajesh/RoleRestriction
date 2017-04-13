namespace RoleRestriction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEventModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventType = c.String(),
                        Starring = c.String(),
                        Date = c.String(),
                        Venue = c.String(),
                        NoOfTickets = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
