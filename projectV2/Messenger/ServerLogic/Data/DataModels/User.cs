using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Data.DataModels
{
    /// <summary>
    /// User table in db
    /// </summary>
    public class User
    {

        [Key]
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserRole { get; set; }
        public string UserImg { get; set; }

        public virtual ICollection<UserInChat> UserInChats { get; set; }
        public virtual ICollection<UserDevice> UserDevices { get; set; }
    }
}
