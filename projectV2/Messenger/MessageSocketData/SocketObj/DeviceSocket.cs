using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.SocketObj
{
    [Serializable]
    public class DeviceSocket
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceIp { get; set; }
        public string DeviceTime { get; set; }
    }
}

