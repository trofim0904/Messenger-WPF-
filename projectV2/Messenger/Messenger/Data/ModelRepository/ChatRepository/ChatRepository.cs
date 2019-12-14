using Messenger.Data.DataModels;
using Messenger.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Messenger.Data.ModelRepository.ChatRepository
{
    public class ChatRepository : GenericRepository<Chat>, IChatRepository
    {
        public void AddMessage(ChatModel chat, string mess)
        {
            Message message = new Message
            {
                MesText = mess,
                MesTime = DateTime.Now.ToShortTimeString(),
                MesUserId = MyUser.User.UserId
            };
            context.Messages.Add(message);

            MessageInChat messageInChat = new MessageInChat
            {
                ChatId = chat.Id,
                MesId = message.MesId
            };
            context.MessageInChats.Add(messageInChat);
            //context.Messages.Add(new Message)
            
        }

        Chat CreateChatByUser(AccountModel user)
        {
            Chat chat = new Chat
            {
                ChatImg = user.AccountImg,
                ChatName = user.AccountLogin,
                ChatStatus = DateTime.Now.ToLongTimeString(),
                ChatType = "solo"
            };
            context.Chats.Add(chat);
            Save();
            context.UsersInChats.Add(new UserInChat() { UserId = user.AccountId, ChatId = chat.ChatId });
            context.UsersInChats.Add(new UserInChat() { UserId = MyUser.User.UserId, ChatId = chat.ChatId });

            return chat;
        }

        public Chat FindSoloChatByUser(AccountModel user)
        {
            //MessageBox.Show(user.AccountId.ToString());
            try
            {
                var list = (from c in context.Chats
                            join uc in context.UsersInChats on c.ChatId equals uc.ChatId
                            join u in context.Users on uc.UserId equals u.UserId
                            where c.ChatType == "solo"
                            where u.UserId == user.AccountId
                            select c).ToList();
                var result = (from c in list
                              join uc in context.UsersInChats on c.ChatId equals uc.ChatId
                              join u in context.Users on uc.UserId equals u.UserId
                              where u.UserId == MyUser.User.UserId
                              select c).First();

                return result;
            }
            catch
            {
                return CreateChatByUser(user);
            }
        }

        
        public IEnumerable<Chat> GetGroupChats(User user)
        {
            return (from c in context.Chats
                    join uc in context.UsersInChats on c.ChatId equals uc.ChatId
                    join u in context.Users on uc.UserId equals u.UserId
                    where c.ChatType == "group"
                    where u.UserId == user.UserId
                    select c).ToList();
        }

        
        public IEnumerable<Message> GetMessages(ChatModel chat)
        {
            return (from m in context.Messages
                    join mc in context.MessageInChats on m.MesId equals mc.MesId
                    join c in context.Chats on mc.ChatId equals c.ChatId
                    where c.ChatId == chat.Id
                    select m).ToList();
        }

        public IEnumerable<Chat> GetSoloChats(User user)
        {
            return (from c in context.Chats
                    join uc in context.UsersInChats on c.ChatId equals uc.ChatId
                    join u in context.Users on uc.UserId equals u.UserId
                    where c.ChatType == "solo"
                    where u.UserId == user.UserId
                    select c).ToList();
        }

        public override void Update(Chat item)
        {
            Chat chat = context.Chats.Find(item.ChatId);
            chat = item;
         
        }
    }
}
