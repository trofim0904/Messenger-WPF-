﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessangerDTO
{
    [DataContract]
    public class RegistrationDTO
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string RepeatPassword { get; set; }
    }
}
