using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Logic.MainLogic
{
    public interface IDeviceLogic
    {
        IEnumerable<DeviceDTO> GetDeviceDTOs(string token);
    }
}
