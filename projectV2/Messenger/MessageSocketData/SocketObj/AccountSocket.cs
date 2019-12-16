using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.SocketObj
{
    [Serializable]
    public class AccountSocket
    {
        public int Id { get; set; }

        public string Login { get; set; }
        
        public string Password { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Role { get; set; }
        
        public string Img { get; set; }

        public string Token { get; set; }
    }
}
