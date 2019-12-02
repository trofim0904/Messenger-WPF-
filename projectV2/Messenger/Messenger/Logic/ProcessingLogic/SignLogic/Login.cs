using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Messenger.Data.DataModels;
using Messenger.Data.ModelRepository.DeviceRepository;
using Messenger.Data.ModelRepository.UserRepository;
using Messenger.Logic.Models;

namespace Messenger.Logic.ProcessingLogic.SignLogic
{
    public class Login : ILogin
    {
        public bool GetLogin(LoginModel model)
        {
            if (model.Username == null)
            {
                Message();
                return false;
                
            }
            if(model.Password == null)
            {
                Message();
                return false;
                
            }
            using(UserRepository repository = new UserRepository())
            {
                User user = repository.GetUserByLoginPassword(model.Username, model.Password);
                if (user != null)
                {
                    MyUser.SetNewUser(user);
                    //return true;
                }
                else
                {
                    Message();
                    return false;
                }
            }
            Device dev = new Device
            {
                DeviceTime = DateTime.Now.ToLongTimeString()
            };
            string host = System.Net.Dns.GetHostName();
            dev.DeviceName = host;
            dev.DeviceIp = Dns.GetHostEntry(host).AddressList[0].ToString();
            using (DeviceRepository repository = new DeviceRepository())
            {
                repository.AddDeviceToUser(dev, MyUser.User);
                repository.Save();
                return true;
            }
           
        }
        private void Message()
        {
            MessageBox.Show("Input username or login", "Error");
        }
    }
}
