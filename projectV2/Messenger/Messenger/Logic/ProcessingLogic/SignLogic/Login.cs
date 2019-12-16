using System;
using System.Net;
using Messenger.Logic.Models;
using Messenger.Mapping;
using Messenger.MessangerService;
using Messenger.Services;

namespace Messenger.Logic.ProcessingLogic.SignLogic
{
    public class Login : ILogin
    {
        
        public bool GetLogin(LoginModel model)
        {

            ISignMap signMap = new Map();


            IService service = new WCFService();
            //Socket service = new Socket();


            AccountDTO accountDTO = new AccountDTO();
            
            string host = System.Net.Dns.GetHostName();
            DeviceDTO deviceDTO = new DeviceDTO
            {
                DeviceIp = Dns.GetHostEntry(host).AddressList[0].ToString(),
                DeviceName = host,
                DeviceTime = DateTime.Now.ToLongTimeString()
            };
            accountDTO = service.LoginService(signMap.LoginModelToLoginDTO(model), deviceDTO);
            if (accountDTO != null)
            {
                MyUser.SetNewUser(signMap.AccountDTOToUserModel(accountDTO));
                return true;
            }
            return false;

           
        }
       
    }
}
