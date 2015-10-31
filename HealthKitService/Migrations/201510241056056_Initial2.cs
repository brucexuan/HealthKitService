namespace HealthKitService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        NickName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Users", "UserDetails_Id", c => c.Int());
            CreateIndex("dbo.Users", "UserDetails_Id");
            AddForeignKey("dbo.Users", "UserDetails_Id", "dbo.UserDetails", "Id");
            DropColumn("dbo.Users", "UserDetails_UserId");
            DropColumn("dbo.Users", "UserDetails_NickName");
            DropColumn("dbo.Users", "UserDetails_Gender");
            DropColumn("dbo.Users", "UserDetails_Birthday");
            DropColumn("dbo.Users", "UserDetails_Height");
            DropColumn("dbo.Users", "UserDetails_Weight");
        }

        public override void Down()
        {
            AddColumn("dbo.Users", "UserDetails_Weight", c => c.Double(nullable: false));
            AddColumn("dbo.Users", "UserDetails_Height", c => c.Double(nullable: false));
            AddColumn("dbo.Users", "UserDetails_Birthday", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "UserDetails_Gender", c => c.String(nullable: false));
            AddColumn("dbo.Users", "UserDetails_NickName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "UserDetails_UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "UserDetails_Id", "dbo.UserDetails");
            DropIndex("dbo.Users", new[] { "UserDetails_Id" });
            DropColumn("dbo.Users", "UserDetails_Id");
            DropTable("dbo.UserDetails");
        }
    }
}
