using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IMessangerService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IMessangerService
    {
        [OperationContract]
        AccountDTO CheckUser(LoginDTO login, DeviceDTO deviceDTO);

        [OperationContract]
        bool GetRegistration(RegistrationDTO registrationDTO);

        [OperationContract]
        IEnumerable<DeviceDTO> GetDevicesByToken(string token);

        [OperationContract]
        bool ChangeAccount(ChangeDTO changeDTO);

        [OperationContract]
        IEnumerable<ChatDTO> GetChats(string token);

        [OperationContract]
        ChatDTO GetOrCreateChat(AccountDTO accountDTO, string token);

        [OperationContract]
        IEnumerable<GroupChatDTO> GetGroupChat(string token);

        [OperationContract]
        IEnumerable<MessageDTO> GetMessages(ChatDTO chatDTO);

        [OperationContract]
        bool SendMessage(ChatDTO chatDTO, string token, string message);

        [OperationContract]
        IEnumerable<AccountDTO> GetAccountsByTeg(string teg, string token);
    }
}
