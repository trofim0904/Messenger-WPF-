using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.MessangerService;

namespace Messenger.Services
{
    /// <summary>
    /// Class that work with server
    /// </summary>
    public class WCFService : IService
    {
        private MessangerService.MessangerServiceClient client;

        //client = new ServiceMessanger.MessangerServiceClient("NetTcpBinding_IMessangerService");
        public WCFService()
        {
            client = new MessangerServiceClient("NetTcpBinding_IMessangerService");
        }

        public bool ChangeAccount(ChangeDTO changeDTO)
        {
            return client.ChangeAccount(changeDTO);
        }
        

        public IEnumerable<AccountDTO> GetAccountsByTeg(string teg, string token)
        {
            return client.GetAccountsByTeg(teg, token);
        }

        public IEnumerable<ChatDTO> GetChats(string token)
        {
            return client.GetChats(token);
        }

        public IEnumerable<DeviceDTO> GetDevicesByToken(string token)
        {
            return client.GetDevicesByToken(token);
        }

        public IEnumerable<GroupChatDTO> GetGroupChat(string token)
        {
            return client.GetGroupChat(token);
        }

        public IEnumerable<MessageDTO> GetMessages(ChatDTO chatDTO)
        {
            return client.GetMessages(chatDTO);
        }

        public ChatDTO GetOrCreateChat(AccountDTO accountDTO, string token)
        {
            return client.GetOrCreateChat(accountDTO, token);
        }

        public AccountDTO LoginService(LoginDTO loginDTO, DeviceDTO deviceDTO)
        {
            return client.CheckUser(loginDTO, deviceDTO);
        }

        public bool Registration(RegistrationDTO registrationDTO)
        {
            return client.GetRegistration(registrationDTO);
        }

        public bool SendMessage(ChatDTO chatDTO, string token, string message)
        {
            return client.SendMessage(chatDTO, token, message);
        }
    }
}
