namespace HealthKitService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        RegisterWay = c.String(nullable: false),
                        UserDetails_UserId = c.Int(nullable: false),
                        UserDetails_NickName = c.String(),
                        UserDetails_Gender = c.String(),
                        UserDetails_Birthday = c.DateTime(nullable: false),
                        UserDetails_Height = c.Double(nullable: false),
                        UserDetails_Weight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
