namespace Messenger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Chats", "ChatAdminId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Chats", "ChatAdminId", c => c.Int(nullable: false));
        }
    }
}
