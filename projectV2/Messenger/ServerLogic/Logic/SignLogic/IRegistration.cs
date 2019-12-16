using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Logic.SignLogic
{
    public interface IRegistration
    {
        bool GetRegistred(RegistrationDTO registrationDTO);
    }
}
