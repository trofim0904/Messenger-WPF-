using Messenger.MessangerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Services
{
    public interface IService
    {
        AccountDTO LoginService(LoginDTO loginDTO, DeviceDTO deviceDTO);

        bool Registration(RegistrationDTO registrationDTO);

        IEnumerable<DeviceDTO> GetDevicesByToken(string token);

        bool ChangeAccount(ChangeDTO changeDTO);

        IEnumerable<AccountDTO> GetAccountsByTeg(string teg, string token);

        IEnumerable<ChatDTO> GetChats(string token);

        IEnumerable<GroupChatDTO> GetGroupChat(string token);

        IEnumerable<MessageDTO> GetMessages(ChatDTO chatDTO);

        bool SendMessage(ChatDTO chatDTO, string token, string message);

        ChatDTO GetOrCreateChat(AccountDTO accountDTO, string token);
    }
}
