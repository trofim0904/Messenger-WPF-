using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Messenger.Data.DataModels;
using Messenger.Data.ModelRepository.UserRepository;
using Messenger.Logic.Models;

namespace Messenger.Logic.ProcessingLogic.AccountLogic
{
    public class ChangeAccLogic : IChangeAccLogic
    {
        public void ChangeAcc(ChangeModel model)
        {
            
            if(model.Img == null)
            {
                Message("img");
                return;
            }
            if(model.Email == null)
            {
                Message("email");
                return;
            }
            if(model.NewPassword == null)
            {
                Message("new password");
                return;
            }
            if(model.OldPassword == null)
            {
                Message("old password");
                return;
            }
            if(model.RepeatPassword == null)
            {
                Message("repeat password");
                return;
            }
            if(model.NewPassword != model.RepeatPassword)
            {
                Message("new pass != repeat pass");
                return;
            }
            if(model.OldPassword != MyUser.User.UserPassword)
            {
                Message("wrong old pass");
                return;
            }
            User user = new User();
            user.UserId = MyUser.User.UserId;
           
            user.UserEmail = model.Email;
            user.UserImg = model.Img;
            user.UserPassword = model.NewPassword;
            //MessageBox.Show(user.UserImg);
            using (UserRepository repository = new UserRepository())
            {
                repository.Update(user);
                
            }

            MessageBox.Show("You update data", "Complete");
        }
        void Message(string error)
        {
            MessageBox.Show($"Input data({error})", "Error");
        }
    }
}
