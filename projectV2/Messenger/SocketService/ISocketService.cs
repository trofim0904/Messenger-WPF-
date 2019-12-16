using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketService
{
    public interface ISocketService
    {
        AccountDTO CheckUser(LoginDTO login, DeviceDTO deviceDTO);

        
        bool GetRegistration(RegistrationDTO registrationDTO);

      
        IEnumerable<DeviceDTO> GetDevicesByToken(string token);

    
        bool ChangeAccount(ChangeDTO changeDTO);

     
        IEnumerable<ChatDTO> GetChats(string token);

     
        ChatDTO GetOrCreateChat(AccountDTO accountDTO, string token);

     
        IEnumerable<GroupChatDTO> GetGroupChat(string token);


        IEnumerable<MessageDTO> GetMessages(ChatDTO chatDTO);

     
        bool SendMessage(ChatDTO chatDTO, string token, string message);

        
        IEnumerable<AccountDTO> GetAccountsByTeg(string teg, string token);
    }
}
