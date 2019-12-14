using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessangerDTO;
using WCFService.Data.DataModels;
using WCFService.Data.ModelRepository.DeviceRepository;
using WCFService.Mapping;

namespace WCFService.Logic.MainLogic
{
    public class DeviceLogic : IDeviceLogic
    {
        public IEnumerable<DeviceDTO> GetDeviceDTOs(string token)
        {
            IEnumerable<Device> devices;
            List<DeviceDTO> deviceDTOs = new List<DeviceDTO>();
            IMainMap map = new Map();
            using (DeviceRepository repository = new DeviceRepository())
            {
                devices = repository.GetUserDevices(UsersData.UserList.Accounts[token].Id);
            }

            foreach(Device device in devices)
            {
                deviceDTOs.Add(map.DeviceToDeviceDTO(device));
            }
            return deviceDTOs;
        }
    }
}
