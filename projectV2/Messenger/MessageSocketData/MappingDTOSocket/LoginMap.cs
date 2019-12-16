using MessageSocketData.SocketObj;
using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.MappingDTOSocket
{
    public class LoginMap : IMapping<LoginDTO, LoginSocket>
    {
        public LoginSocket MapFrom(LoginDTO obj)
        {
            LoginSocket loginSocket = new LoginSocket()
            {
                Username = obj.Username,
                Password = obj.Password
            };
            return loginSocket;
        }

        public LoginDTO MapTo(LoginSocket obj)
        {
            LoginDTO loginDTO = new LoginDTO()
            {
                Username = obj.Username,
                Password = obj.Password
            };
            return loginDTO;

        }
    }
}
