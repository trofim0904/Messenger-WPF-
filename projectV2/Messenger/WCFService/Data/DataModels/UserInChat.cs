using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.Data.DataModels
{
    /// <summary>
    /// Isolation table
    /// </summary>
    public class UserInChat
    {
        [Key]
        public int UsInChId { get; set; }
        public int UserId { get; set; }
        public int ChatId { get; set; }

        public virtual User User { get; set; }
        public virtual Chat Chat { get; set; }
    }
}
