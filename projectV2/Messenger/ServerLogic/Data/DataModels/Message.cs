using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Data.DataModels
{
    public class Message
    {
        [Key]
        public int MesId { get; set; }
        public string MesTime { get; set; }
        public string MesText { get; set; }
        public int MesUserId { get; set; }

        public virtual ICollection<MessageInChat> MessageInChats { get; set; }
    }
}
