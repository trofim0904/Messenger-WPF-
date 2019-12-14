using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessangerDTO;
using WCFService.Data.ModelRepository.DeviceRepository;
using WCFService.Data.ModelRepository.UserRepository;
using WCFService.Logic.Models;
using WCFService.Mapping;
using WCFService.UsersData;

namespace WCFService.Logic.SignLogic
{
    public class SignLogic : ILogin, IRegistration
    {
        private IMapUser map = new Map();
        private IMainMap deviceMap = new Map();
        private HashLogic hash = new HashLogic();
        
        public AccountDTO GetLogin(LoginDTO loginDTO, DeviceDTO deviceDTO)
        {
            if (loginDTO.Username == null)
            {

                return null;

            }
            if (loginDTO.Password == null)
            {

                return null;

            }
            string result = null;
            AccountDTO account = new AccountDTO();
            LoginModel model = map.LoginDTOToLoginModel(loginDTO);
            using (UserRepository repository = new UserRepository())
            {
               account = map.UserToAccountDTO(repository.GetUserByLoginPassword(model.Username, model.Password));
              
            }
            if (account != null)
            {
               
                result = hash.ComputeHash(account.Login, account.Password);
                UserList.Accounts.TryAdd(result, map.AccountDTOToAccountModel(account));
                account.Token = result;
                using (DeviceRepository repository = new DeviceRepository())
                {
                    repository.AddDeviceToUser(deviceMap.DeviceDTOToDevice(deviceDTO), UserList.Accounts[result].Id);
                    repository.Save();
                }
            }
            else
            {
                result = null;
            }
            return account;
        }

        public bool GetRegistred(RegistrationDTO registrationDTO)
        {

            RegistrationModel model = 
                map.RegistrationDTOToRegistrationModel(registrationDTO);

            if (model == null)
            {
                return false;
            }
            if (model.Password == null)
            {
                return false;
            }
            if (model.RepeatPassword == null)
            {
                return false;
            }
            if (!CheckPasswords(model.Password, model.RepeatPassword))
            {
                return false;
            }
            if (model.Login == null)
            {
                return false;
            }
            if (model.Email == null)
            {
                return false;
            }
            if (model.PhoneNumber == null)
            {
                return false;
            }
            if (model.PhoneNumber.Length != 12)
            {
                return false;
            }
            if (!model.Email.Contains('@'))
            {
                return false;
            }
            using (UserRepository repository = new UserRepository())
            {
                if (repository.CheckLogin(model.Login))
                {
                    
                    return false;
                }
                if (repository.CheckPhoneNumber(model.PhoneNumber))
                {
                    
                    return false;
                }
                repository.Create(map.RegistrationModelToUser(model));
                repository.Save();
            }
            return true;
        }

        bool CheckPasswords(string pass1, string pass2)
        {
            if (pass1.Equals(pass2))
            {
                return true;
            }
            return false;
        }
        
    }
}
