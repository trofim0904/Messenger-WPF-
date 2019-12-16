using MessangerDTO;
using System.Collections.Generic;
using ServerLogic.Data.DataModels;

namespace ServerLogic.Data.ModelRepository.ChatRepository
{
    public interface IChatRepository : IRepository<Chat>
    {
        IEnumerable<Chat> GetSoloChats(User user);
        IEnumerable<Chat> GetGroupChats(User user);

        IEnumerable<Message> GetMessages(Chat chat);
        void AddMessage(Chat chat, string mess, string token);

        Chat FindSoloChatByUser(User user, string token);
        //Chat CreateChatByUser(AccountDTO account);
    }
}
