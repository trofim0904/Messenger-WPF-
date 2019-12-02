using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Messenger.Data.DataModels;
using Messenger.Data.ModelRepository.DeviceRepository;
using Messenger.Logic.ViewModel.MainVM;
using Messenger.Presentation.View.Main.UserControls;

namespace Messenger.Logic.ProcessingLogic.DeviceLogic
{
    public class DeviceLogic : IDeviceLogic
    {
        public IEnumerable<DeviceUC> GetDeviceUCByUserId(int id)
        {
            List<DeviceUC> deviceUCs = new List<DeviceUC>();
            IEnumerable<Device> devices;
             
            using (DeviceRepository repository = new DeviceRepository())
            {
                devices = repository.GetUserDevices(id);
            }
            if (devices != null)
            {
                int i = 1;
                foreach (Device dev in devices)
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
        //public IEnumerable<Device> GetDevices(int id)
        //{
            
        //}
    }
}
