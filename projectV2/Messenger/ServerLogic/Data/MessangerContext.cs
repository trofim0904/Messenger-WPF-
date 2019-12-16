using System.Data.Entity;
using ServerLogic.Data.DataModels;

namespace ServerLogic.Data
{
    public class MessangerContext : DbContext
    {
        public MessangerContext():base("MessangerDB")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserDevice> UserDevices { get; set; }
        public DbSet<UserInChat> UsersInChats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageInChat> MessageInChats { get; set; }
    }
}
