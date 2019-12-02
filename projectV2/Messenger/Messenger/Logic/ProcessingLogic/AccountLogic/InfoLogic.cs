using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.Logic.Models;

namespace Messenger.Logic.ProcessingLogic.AccountLogic
{
    public class InfoLogic : IInfoLogic
    {
        public AccountModel GetAccount()
        {
            AccountModel accountModel = new AccountModel
            {
                AccountEmail = MyUser.User.UserEmail,
                AccountLogin = MyUser.User.UserLogin,
                AccountImg = MyUser.User.UserImg,
                AccountPhoneNumber = MyUser.User.UserPhoneNumber
            };
            return accountModel;
        }
    }
}
