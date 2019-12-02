using Messenger.Data.DataModels;
using Messenger.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data.ModelRepository.ChatRepository
{
    public interface IChatRepository : IRepository<Chat>
    {
        IEnumerable<Chat> GetSoloChats(User user);
        IEnumerable<Chat> GetGroupChats(User user);

        IEnumerable<Message> GetMessages(ChatModel chat);
        void AddMessage(ChatModel chat, string mess);

        Chat FindSoloChatByUser(AccountModel user);
        //Chat CreateChatByUser(AccountModel user);
    }
}
