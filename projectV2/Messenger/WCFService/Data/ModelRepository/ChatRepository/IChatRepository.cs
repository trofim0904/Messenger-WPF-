using MessangerDTO;
using System.Collections.Generic;
using WCFService.Data.DataModels;

namespace WCFService.Data.ModelRepository.ChatRepository
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
