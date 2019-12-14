using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService.Data.DataModels;
using WCFService.Logic.Models;

namespace WCFService.Mapping
{
    public interface IMapUser
    {
        LoginModel LoginDTOToLoginModel(LoginDTO loginDTO);

        RegistrationModel RegistrationDTOToRegistrationModel(RegistrationDTO registrationDTO);

        User RegistrationModelToUser(RegistrationModel registrationModel);

        User AccountModelToUser(AccountModel accountModel);

        User AccountDTOToUser(AccountDTO accountDTO);

        AccountDTO UserToAccountDTO(User user);

        AccountModel UserToAccountModel(User user);

        AccountModel AccountDTOToAccountModel(AccountDTO accountDTO);


    }
}
