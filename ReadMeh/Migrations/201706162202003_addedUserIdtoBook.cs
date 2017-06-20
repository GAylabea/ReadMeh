namespace ReadMeh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedUserIdtoBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "userId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "userId");
        }
    }
}
