using System.Collections.Generic;
using MessangerDTO;
using ServerLogic.Logic.MainLogic;
using ServerLogic.Logic.SignLogic;

namespace WCFService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "MessangerService" в коде и файле конфигурации.
    public class MessangerService : IMessangerService
    {
        public bool ChangeAccount(ChangeDTO changeDTO)
        {
            IAccountLogic accountLogic = new AccountLogic();
            return accountLogic.ChangeAccount(changeDTO);
        }

        public AccountDTO CheckUser(LoginDTO login, DeviceDTO deviceDTO)
        {
            
            ILogin loginlogic = new SignLogic();
            AccountDTO accountDTO = new AccountDTO();
            accountDTO = loginlogic.GetLogin(login, deviceDTO);

            return accountDTO;
        }

        public IEnumerable<AccountDTO> GetAccountsByTeg(string teg, string token)
        {
            IAccountLogic accountLogic = new AccountLogic();
            return accountLogic.GetAccountsByTeg(teg, token);
        }

        public IEnumerable<ChatDTO> GetChats(string token)
        {
            IChatLogic<ChatDTO> chatLogic = new SoloChatLogic();
            return chatLogic.GetChats(token);
        }

        public IEnumerable<DeviceDTO> GetDevicesByToken(string token)
        {
            IDeviceLogic deviceLogic = new DeviceLogic();
            return deviceLogic.GetDeviceDTOs(token);
        }

        public IEnumerable<GroupChatDTO> GetGroupChat(string token)
        {
            IChatLogic<GroupChatDTO> chatLogic = new GroupChatLogic();
            return chatLogic.GetChats(token);
        }

        public IEnumerable<MessageDTO> GetMessages(ChatDTO chatDTO)
        {
            IMessageLogic messageLogic = new MessageLogic();
            return messageLogic.GetMessages(chatDTO);
        }

        public ChatDTO GetOrCreateChat(AccountDTO accountDTO, string token)
        {
            IChatLogic<ChatDTO> chatLogic = new SoloChatLogic();
            return chatLogic.GetOrCreateChat(accountDTO, token);
        }

        public bool GetRegistration(RegistrationDTO registrationDTO)
        {
            IRegistration registrationlogic = new SignLogic();
            return registrationlogic.GetRegistred(registrationDTO);
        }

        public bool SendMessage(ChatDTO chatDTO, string token, string message)
        {
            IMessageLogic messageLogic = new MessageLogic();
            return messageLogic.SendMessage(chatDTO, token, message);
        }
    }
}
