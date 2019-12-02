using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Logic.Models
{
    public class GroupChatModel : ChatModel
    {
        public int? ChatAdminId { get; set; }
    }
}
