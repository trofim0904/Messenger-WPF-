using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessangerDTO
{
    [DataContract]
    public class MessageDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public string Time { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Img { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }
}
