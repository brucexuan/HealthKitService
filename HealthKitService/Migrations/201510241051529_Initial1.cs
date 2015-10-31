namespace HealthKitService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserDetails_NickName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "UserDetails_Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserDetails_Gender", c => c.String());
            AlterColumn("dbo.Users", "UserDetails_NickName", c => c.String());
        }
    }
}
