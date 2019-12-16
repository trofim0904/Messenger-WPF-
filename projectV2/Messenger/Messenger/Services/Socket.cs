using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MessageSocketData.MappingDTOSocket;
using MessageSocketData.SocketObj;
using Messenger.MessangerService;

namespace Messenger.Services
{
    public class Socket
    {
        private readonly string ip;
        private readonly int port;
        private TcpClient tcpClient;

        public Socket()
        {
            ip = "127.0.0.1";
            port = 40000;

            tcpClient = new TcpClient(ip, port);
        }
        

        public AccountDTO LoginService(LoginDTO loginDTO, DeviceDTO deviceDTO)
        {
            
            NetworkStream networkStream = tcpClient.GetStream();
            BinaryFormatter bf = new BinaryFormatter();
          

            DataToSend dataToSend = new DataToSend()
            {
                FirstObject = new LoginSocket() { Username = loginDTO.Username, Password = loginDTO.Password },
                Action = MessageSocketData.SocketObj.Action.Login,
                SecondObject = new DeviceSocket()
                {
                    DeviceId = deviceDTO.DeviceId,
                    DeviceIp = deviceDTO.DeviceIp,
                    DeviceName = deviceDTO.DeviceName,
                    DeviceTime = deviceDTO.DeviceTime
                }
            };

            
            bf.Serialize(networkStream, dataToSend);


            ///////////////////////////////////////////////////////////////
            DataToSend answer = bf.Deserialize(tcpClient.GetStream()) as DataToSend;
            var obj = (answer.FirstObject as AccountSocket);
            AccountDTO accountDTO = new AccountDTO()
            {
                Email = obj.Email,
                Id = obj.Id,
                Img = obj.Img,
                Login = obj.Login,
                Password = obj.Password,
                PhoneNumber = obj.PhoneNumber,
                Role = obj.Role,
                Token = obj.Token
            };
            return accountDTO;

        }

        public bool Registration(RegistrationDTO registrationDTO)
        {
            NetworkStream networkStream = tcpClient.GetStream();
            BinaryFormatter bf = new BinaryFormatter();


            DataToSend dataToSend = new DataToSend()
            {
                FirstObject = new RegistrationSocket()
                {
                    Email = registrationDTO.Email,
                    Login = registrationDTO.Login,
                    Password = registrationDTO.Password,
                    PhoneNumber = registrationDTO.PhoneNumber,
                    RepeatPassword = registrationDTO.RepeatPassword
                },
                Action = MessageSocketData.SocketObj.Action.Registration,
                
            };


            bf.Serialize(networkStream, dataToSend);


            ///////////////////////////////////////////////////////////////
            DataToSend answer = bf.Deserialize(tcpClient.GetStream()) as DataToSend;
            bool obj = (answer.Boolean);
           
            return obj;
        }

      
    }
}
