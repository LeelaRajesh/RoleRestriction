namespace RoleRestriction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingLeadRoleFromMovie : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MovieModels", newName: "Movies");
            DropColumn("dbo.Movies", "LeadRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "LeadRole", c => c.String());
            RenameTable(name: "dbo.Movies", newName: "MovieModels");
        }
    }
}
