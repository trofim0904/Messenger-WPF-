namespace WCFService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        ChatId = c.Int(nullable: false, identity: true),
                        ChatType = c.String(),
                        ChatStatus = c.String(),
                        ChatAdminId = c.Int(),
                        ChatImg = c.String(),
                        ChatName = c.String(),
                    })
                .PrimaryKey(t => t.ChatId);
            
            CreateTable(
                "dbo.UserInChats",
                c => new
                    {
                        UsInChId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ChatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsInChId)
                .ForeignKey("dbo.Chats", t => t.ChatId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ChatId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserLogin = c.String(),
                        UserPassword = c.String(),
                        UserEmail = c.String(),
                        UserPhoneNumber = c.String(),
                        UserRole = c.String(),
                        UserImg = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        DeviceId = c.Int(nullable: false, identity: true),
                        DeviceName = c.String(),
                        DeviceIp = c.String(),
                        DeviceTime = c.String(),
                    })
                .PrimaryKey(t => t.DeviceId);
            
            CreateTable(
                "dbo.UserDevices",
                c => new
                    {
                        UsDevId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        DeviceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsDevId)
                .ForeignKey("dbo.Devices", t => t.DeviceId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.DeviceId);
            
            CreateTable(
                "dbo.MessageInChats",
                c => new
                    {
                        MesInChId = c.Int(nullable: false, identity: true),
                        MesId = c.Int(nullable: false),
                        ChatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MesInChId)
                .ForeignKey("dbo.Chats", t => t.ChatId, cascadeDelete: true)
                .ForeignKey("dbo.Messages", t => t.MesId, cascadeDelete: true)
                .Index(t => t.MesId)
                .Index(t => t.ChatId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MesId = c.Int(nullable: false, identity: true),
                        MesTime = c.String(),
                        MesText = c.String(),
                        MesUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MessageInChats", "MesId", "dbo.Messages");
            DropForeignKey("dbo.MessageInChats", "ChatId", "dbo.Chats");
            DropForeignKey("dbo.UserDevices", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserDevices", "DeviceId", "dbo.Devices");
            DropForeignKey("dbo.UserInChats", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserInChats", "ChatId", "dbo.Chats");
            DropIndex("dbo.MessageInChats", new[] { "ChatId" });
            DropIndex("dbo.MessageInChats", new[] { "MesId" });
            DropIndex("dbo.UserDevices", new[] { "DeviceId" });
            DropIndex("dbo.UserDevices", new[] { "UserId" });
            DropIndex("dbo.UserInChats", new[] { "ChatId" });
            DropIndex("dbo.UserInChats", new[] { "UserId" });
            DropTable("dbo.Messages");
            DropTable("dbo.MessageInChats");
            DropTable("dbo.UserDevices");
            DropTable("dbo.Devices");
            DropTable("dbo.Users");
            DropTable("dbo.UserInChats");
            DropTable("dbo.Chats");
        }
    }
}
