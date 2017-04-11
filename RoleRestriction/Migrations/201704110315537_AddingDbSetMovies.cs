namespace RoleRestriction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDbSetMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        LeadRole = c.String(),
                        Price = c.Int(nullable: false),
                        AvailableSeats = c.Int(nullable: false),
                        DateToBook = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieModels");
        }
    }
}
