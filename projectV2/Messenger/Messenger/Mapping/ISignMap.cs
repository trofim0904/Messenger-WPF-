using Messenger.Logic.Models;
using Messenger.MessangerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Mapping
{
    public interface ISignMap
    {
        LoginDTO LoginModelToLoginDTO(LoginModel model);

        UserModel AccountDTOToUserModel(AccountDTO accountDTO);

        RegistrationDTO RegistrationModelToRegistrationDTO(RegistrationModel registrationModel);
    }
}
