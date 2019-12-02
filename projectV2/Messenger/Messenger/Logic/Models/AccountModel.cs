using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Logic.Models
{
    public class AccountModel
    {
        public int AccountId { get; set; }
        public string AccountImg { get; set; }
        public string AccountEmail { get; set; }
        public string AccountLogin { get; set; }
        public string AccountPhoneNumber { get; set; }
    }
}
