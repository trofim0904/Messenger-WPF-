using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerLogic.Data.DataModels;
using ServerLogic.Logic.Models;

namespace ServerLogic.Mapping
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
