using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.Logic.MainLogic
{
    public interface IDeviceLogic
    {
        IEnumerable<DeviceDTO> GetDeviceDTOs(string token);
    }
}
