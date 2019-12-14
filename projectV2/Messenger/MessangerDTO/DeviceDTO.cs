using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessangerDTO
{
    [DataContract]
    public class DeviceDTO
    {
        [DataMember]
        public int DeviceId { get; set; }
        [DataMember]
        public string DeviceName { get; set; }
        [DataMember]
        public string DeviceIp { get; set; }
        [DataMember]
        public string DeviceTime { get; set; }
    }
}
