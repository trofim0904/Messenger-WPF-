using MessageSocketData.SocketObj;
using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.MappingDTOSocket
{
    public class DeviceMap : IMapping<DeviceDTO, DeviceSocket>
    {
        public DeviceSocket MapFrom(DeviceDTO obj)
        {
            DeviceSocket deviceSocket = new DeviceSocket()
            {
                DeviceId = obj.DeviceId,
                DeviceIp = obj.DeviceIp,
                DeviceName = obj.DeviceName,
                DeviceTime = obj.DeviceTime
            };
            return deviceSocket;
        }

        public DeviceDTO MapTo(DeviceSocket obj)
        {
            DeviceDTO deviceDTO = new DeviceDTO()
            {
                DeviceId = obj.DeviceId,
                DeviceIp = obj.DeviceIp,
                DeviceName = obj.DeviceName,
                DeviceTime = obj.DeviceTime
            };
            return deviceDTO;

        }
    }
}
