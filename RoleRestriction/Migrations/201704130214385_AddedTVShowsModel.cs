namespace RoleRestriction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTVShowsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TVShows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NoOfSeasons = c.Int(nullable: false),
                        EpisodesPerSeason = c.Int(nullable: false),
                        Genre = c.String(),
                        Region = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TVShows");
        }
    }
}
