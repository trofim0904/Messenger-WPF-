using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.SocketObj
{
    [Serializable]
    public class LoginSocket
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
