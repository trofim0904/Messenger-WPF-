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
    public class UserDevice
    {
        [Key]
        public int UsDevId { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }

        public virtual Device Device { get; set; }
        public virtual User User { get; set; }
    }
}
