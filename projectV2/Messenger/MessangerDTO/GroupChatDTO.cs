using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessangerDTO
{
    [DataContract]
    public class GroupChatDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Img { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int? ChatAdminId { get; set; }
    }
}
