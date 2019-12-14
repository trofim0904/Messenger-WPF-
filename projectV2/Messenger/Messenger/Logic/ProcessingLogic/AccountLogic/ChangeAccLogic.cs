using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Messenger.Data.DataModels;
using Messenger.Data.ModelRepository.UserRepository;
using Messenger.Logic.Models;
using Messenger.Mapping;
using Messenger.Services;

namespace Messenger.Logic.ProcessingLogic.AccountLogic
{
    public class ChangeAccLogic : IChangeAccLogic
    {
        public bool ChangeAccount(ChangeModel model)
        {

            IService service = new WCFService();
            IUserMap userMap = new Map();
            if (service.ChangeAccount(userMap.ChangeModelToChangeDTO(model)))
            {
                MyUser.User.UserEmail = model.Email;
                MyUser.User.UserImg = model.Img;
                MyUser.User.UserPassword = model.NewPassword;
                return true;
            }

            return false;
        }
        
    }
}
