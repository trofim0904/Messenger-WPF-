using MessageSocketData.SocketObj;
using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.MappingDTOSocket
{
    public class RegistrationMap : IMapping<RegistrationDTO, RegistrationSocket>
    {
        public RegistrationSocket MapFrom(RegistrationDTO obj)
        {
            RegistrationSocket registrationSocket = new RegistrationSocket()
            {
                Email = obj.Email,
                Login = obj.Login,
                Password = obj.Password,
                PhoneNumber = obj.PhoneNumber,
                RepeatPassword = obj.RepeatPassword
            };
            return registrationSocket;
        }

        public RegistrationDTO MapTo(RegistrationSocket obj)
        {
            RegistrationDTO registrationDTO = new RegistrationDTO()
            {
                Email = obj.Email,
                Login = obj.Login,
                Password = obj.Password,
                PhoneNumber = obj.PhoneNumber,
                RepeatPassword = obj.RepeatPassword
            };
            return registrationDTO;
        }
    }
}
