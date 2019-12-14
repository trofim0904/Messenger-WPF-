using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using WCFService.Data.DataModels;
using WCFService.UsersData;

namespace WCFService.Data.ModelRepository.ChatRepository
{
    public class ChatRepository : GenericRepository<Chat>, IChatRepository
    {
        
        public void AddMessage(Chat chat, string mess, string token)
        {
            int id = UserList.Accounts[token].Id;
            Message message = new Message
            {
                MesText = mess,
                MesTime = DateTime.Now.ToShortTimeString(),
                MesUserId = id
            };
            context.Messages.Add(message);

            MessageInChat messageInChat = new MessageInChat
            {
                ChatId = chat.ChatId,
                MesId = message.MesId
            };
            context.MessageInChats.Add(messageInChat);
            //context.Messages.Add(new Message)
            
        }

        Chat CreateChatByUser(User user, string token)
        {
            
            Chat chat = new Chat
            {
                ChatImg = user.UserImg,
                ChatName = user.UserLogin,
                ChatStatus = DateTime.Now.ToLongTimeString(),
                ChatType = "solo"
            };
            context.Chats.Add(chat);
            Save();
            int i = UserList.Accounts[token].Id;
            context.UsersInChats.Add(new UserInChat() { UserId = user.UserId, ChatId = chat.ChatId });
            context.UsersInChats.Add(new UserInChat() { UserId = i, ChatId = chat.ChatId });


            return chat;
        }

        public Chat FindSoloChatByUser(User user, string token)
        {
            try
            {
                var list = (from c in context.Chats
                            join uc in context.UsersInChats on c.ChatId equals uc.ChatId
                            join u in context.Users on uc.UserId equals u.UserId
                            where c.ChatType == "solo"
                            where u.UserId == user.UserId
                            select c).ToList();
                int i = UserList.Accounts[token].Id;
                var result = (from c in list
                              join uc in context.UsersInChats on c.ChatId equals uc.ChatId
                              join u in context.Users on uc.UserId equals u.UserId
                              where u.UserId == i
                              select c).First();

                return result;
            }
            catch
            {
                return CreateChatByUser(user, token);
            }
        }

        
        public IEnumerable<Chat> GetGroupChats(User user)
        {
            
            return  (from c in context.Chats
                    join uc in context.UsersInChats on c.ChatId equals uc.ChatId
                    join u in context.Users on uc.UserId equals u.UserId
                    where c.ChatType == "group"
                    where u.UserId == user.UserId
                    select c).ToList();
            
            
        }

        
        public IEnumerable<Message> GetMessages(Chat chat)
        {
            
            return  (from m in context.Messages
                    join mc in context.MessageInChats on m.MesId equals mc.MesId
                    join c in context.Chats on mc.ChatId equals c.ChatId
                    where c.ChatId == chat.ChatId
                    select m).ToList();
        }

        public IEnumerable<Chat> GetSoloChats(User user)
        {
            return  (from c in context.Chats
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
