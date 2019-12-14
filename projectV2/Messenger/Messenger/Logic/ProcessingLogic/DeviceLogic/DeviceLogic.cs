using System.Collections.Generic;
using Messenger.MessangerService;
using Messenger.Presentation.View.Main.UserControls;
using Messenger.Services;

namespace Messenger.Logic.ProcessingLogic.DeviceLogic
{
    public class DeviceLogic : IDeviceLogic
    {
        public IEnumerable<DeviceUC> GetDeviceUC()
        {
            List<DeviceUC> deviceUCs = new List<DeviceUC>();
            IEnumerable<DeviceDTO> deviceDTOs;
            IService service = new WCFService();

            deviceDTOs = service.GetDevicesByToken(MyUser.User.UserToken);
           
            if (deviceDTOs != null)
            {
                int i = 1;
                foreach (DeviceDTO dev in deviceDTOs)
                {
                    
                    DeviceUC deviceUC = new DeviceUC();
                    deviceUC._idTb.Text = i++ + ".";
                    deviceUC._nameTb.Text = dev.DeviceName;
                    deviceUC._ipTb.Text = dev.DeviceIp;
                    deviceUC._timeTb.Text = dev.DeviceTime;
                    deviceUCs.Add(deviceUC);
                    
                }
            }
            
            return deviceUCs;
        }
       
    }
}
