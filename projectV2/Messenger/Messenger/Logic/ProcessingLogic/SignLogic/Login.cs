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
        IService service;
        public bool GetLogin(LoginModel model)
        {

            ISignMap signMap = new Map();
            service = new WCFService();
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
                //MessageBox.Show(result);
                MyUser.SetNewUser(signMap.AccountDTOToUserModel(accountDTO));
                return true;
            }
            return false;

            //Device dev = new Device
            //{
            //    DeviceTime = DateTime.Now.ToLongTimeString()
            //};
            //string host = System.Net.Dns.GetHostName();
            //dev.DeviceName = host;
            //dev.DeviceIp = Dns.GetHostEntry(host).AddressList[0].ToString();
            //using (DeviceRepository repository = new DeviceRepository())
            //{
            //    repository.AddDeviceToUser(dev, MyUser.User);
            //    repository.Save();
            //    return true;
            //}
           
        }
       
    }
}
