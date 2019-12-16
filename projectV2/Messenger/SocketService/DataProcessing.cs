using MessageSocketData.MappingDTOSocket;
using MessageSocketData.SocketObj;
using MessangerDTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketService
{
    public class DataProcessing
    {
        public DataToSend Processing(DataToSend inputData)
        {
            ISocketService socketService = new SocketService();
            DataToSend outputData = new DataToSend();
            LoginMap loginMap = new LoginMap();
            DeviceMap deviceMap = new DeviceMap();
            AccountMap accountMap = new AccountMap();
            RegistrationMap registrationMap = new RegistrationMap();
            if (inputData.Action == MessageSocketData.SocketObj.Action.Login)
            {
                Console.WriteLine("Login...");
                LoginDTO loginDTO = loginMap.MapTo(inputData.FirstObject as LoginSocket);
                DeviceDTO deviceDTO = deviceMap.MapTo(inputData.SecondObject as DeviceSocket);
                AccountDTO accountDTO = new AccountDTO();
                accountDTO = socketService.CheckUser(loginDTO, deviceDTO);
                outputData.FirstObject = accountMap.MapFrom(accountDTO);
            }
            if (inputData.Action == MessageSocketData.SocketObj.Action.Registration)
            {
                Console.WriteLine("Registration...");
                RegistrationDTO registrationDTO = registrationMap.MapTo(inputData.FirstObject as RegistrationSocket);


                bool answer = socketService.GetRegistration(registrationDTO);
                outputData.Boolean = answer;
            }


            return outputData;
        }
    }
}
