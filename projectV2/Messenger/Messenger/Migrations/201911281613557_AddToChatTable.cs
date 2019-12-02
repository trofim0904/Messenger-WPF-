namespace Messenger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToChatTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chats", "ChatName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chats", "ChatName");
        }
    }
}
