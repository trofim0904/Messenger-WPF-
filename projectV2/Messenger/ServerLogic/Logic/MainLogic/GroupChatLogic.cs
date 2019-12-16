using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessangerDTO;
using ServerLogic.Data.DataModels;
using ServerLogic.Data.ModelRepository.ChatRepository;
using ServerLogic.Mapping;

namespace ServerLogic.Logic.MainLogic
{
    public class GroupChatLogic : IChatLogic<GroupChatDTO>
    {
        public IEnumerable<GroupChatDTO> GetChats(string token)
        {
            List<GroupChatDTO> chatDTOs = new List<GroupChatDTO>();
            IEnumerable<Chat> groupChats;
            IMapUser userMap = new Map();
            IMainMap mainMap = new Map();
            using (ChatRepository repository = new ChatRepository())
            {
                groupChats = repository.GetGroupChats(userMap.AccountModelToUser(UsersData.UserList.Accounts[token]));
            }
            foreach(Chat chat in groupChats)
            {
                chatDTOs.Add(mainMap.ChatToGroupChatDTO(chat));
            }

            return chatDTOs;
        }

        public GroupChatDTO GetOrCreateChat(AccountDTO accountDTO, string token)
        {
            throw new NotImplementedException();
            ///This func dont work
            ///It will create new group chat
        }
    }
}
