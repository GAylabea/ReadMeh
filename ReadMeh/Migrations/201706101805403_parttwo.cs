namespace ReadMeh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class parttwo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rating = c.Int(nullable: false),
                        unReview = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "User_Id", "dbo.Users");
            DropIndex("dbo.Books", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Books");
        }
    }
}
