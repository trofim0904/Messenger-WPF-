using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.Data.DataModels
{
    public class MessageInChat
    {
        [Key]
        public int MesInChId { get; set; }
        public int MesId { get; set; }
        public int ChatId { get; set; }

        public virtual Message Message { get; set; }
        public virtual Chat Chat { get; set; }
    }
}
