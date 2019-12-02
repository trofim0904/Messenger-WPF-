namespace Messenger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationAddFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chats", "ChatImg", c => c.String());
            AddColumn("dbo.Users", "UserImg", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UserImg");
            DropColumn("dbo.Chats", "ChatImg");
        }
    }
}
