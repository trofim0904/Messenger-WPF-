using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Messenger.Data.DataModels;
using Messenger.Data.ModelRepository.UserRepository;
using Messenger.Logic.Models;

namespace Messenger.Logic.ProcessingLogic.SignLogic
{
    public class Registration : IRegistration
    {
        public bool GetRegistred(RegistrationModel model)
        {
            if (model == null)
            {
                return false;
            }
            if (model.Password == null)
            {
                return false;
            }
            if(model.RepeatPassword == null)
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
                    MessageBox.Show("This login is already in use. Use another one", "Error");
                    return false;
                }
                if (repository.CheckPhoneNumber(model.PhoneNumber))
                {
                    MessageBox.Show("This phone number is already in use. Use another one", "Error");
                    return false;
                }
                repository.Create(RegModelToUser(model));
                repository.Save();
            }
                return true;
        }

        bool CheckPasswords(string pass1,string pass2)
        {
            if (pass1.Equals(pass2))
            {
                return true;
            }
            return false;
        }
        User RegModelToUser(RegistrationModel registration)
        {
            User user = new User()
            {
                UserEmail = registration.Email,
                UserLogin = registration.Login,
                UserPassword = registration.Password,
                UserPhoneNumber = registration.PhoneNumber,
                UserRole = "user"

            };
            return user;
        }
    }
}
