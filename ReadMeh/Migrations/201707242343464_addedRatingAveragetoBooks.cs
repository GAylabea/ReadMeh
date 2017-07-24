namespace ReadMeh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRatingAveragetoBooks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "RatingAverage", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "RatingAverage");
        }
    }
}
