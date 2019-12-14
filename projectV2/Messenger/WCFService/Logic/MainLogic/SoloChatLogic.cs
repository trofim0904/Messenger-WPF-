using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MessangerDTO;
using WCFService.Data.DataModels;
using WCFService.Data.ModelRepository.ChatRepository;
using WCFService.Data.ModelRepository.UserRepository;
using WCFService.Mapping;

namespace WCFService.Logic.MainLogic
{
    public class SoloChatLogic : IChatLogic<ChatDTO>
    {
        IMapUser userMap = new Map();
        IMainMap mainMap = new Map();

        public IEnumerable<ChatDTO> GetChats(string token)
        {

            IEnumerable<Chat> soloChats = new List<Chat>();
            List<ChatDTO> soloChatsDTO = new List<ChatDTO>();

            using (ChatRepository repository = new ChatRepository())
            {
                soloChats = repository.GetSoloChats(userMap.AccountModelToUser(UsersData.UserList.Accounts[token]));
            }
            
            
            using (UserRepository repository = new UserRepository())
            {
                if(soloChats != null)
                foreach (Chat chat in soloChats)
                {

                    chat.ChatImg = repository.GetUserFromChat(chat, token).UserImg;
                    chat.ChatName = repository.GetUserFromChat(chat, token).UserLogin;
                    //repository.Save();
                }
            }
            
            
            
            if(soloChats != null) 
            foreach (Chat chat in soloChats)
            {
                soloChatsDTO.Add(mainMap.ChatToChatDTO(chat));
            }

            return soloChatsDTO;
        }

        public ChatDTO GetOrCreateChat(AccountDTO accountDTO, string token)
        {
            IMapUser mapUser = new Map();
            IMainMap mainMap = new Map();
            Chat chat = new Chat();
            using (ChatRepository repository = new ChatRepository())
            {
                chat = repository.FindSoloChatByUser(mapUser.AccountDTOToUser(accountDTO), token);
                repository.Save();
        
            }
            using (UserRepository repository = new UserRepository())
            {
                chat.ChatImg = repository.GetUserFromChat(chat, token).UserImg;
                chat.ChatName = repository.GetUserFromChat(chat, token).UserLogin;
            }
            return mainMap.ChatToChatDTO(chat);

        }
    }
}
