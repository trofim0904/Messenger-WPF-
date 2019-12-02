﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data.DataModels
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceIp { get; set; }
        public string DeviceTime { get; set; }

        public virtual ICollection<UserDevice> UserDevices { get; set; }
        
    }
}
