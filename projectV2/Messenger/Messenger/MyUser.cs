using Messenger.Data.DataModels;
using Messenger.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    public class MyUser
    {
        
        public readonly static UserModel User = new UserModel();
        //{
        //    UserId = 1,
        //    UserEmail = "default@",
        //    UserImg = "https://atribootica.ru/upload/200_200/10/9c/109c69cbe068802f2b3393ce6feaaeee.png",
        //    UserLogin = "default",
        //    UserPassword = "default",
        //    UserPhoneNumber = "380000000000",
        //    UserRole = "user"
        //};
        public static void SetNewUser(UserModel user)
        {
            User.UserEmail = user.UserEmail;
            User.UserId = user.UserId;
            User.UserImg = user.UserImg;
            User.UserLogin = user.UserLogin;
            User.UserPassword = user.UserPassword;
            User.UserPhoneNumber = user.UserPhoneNumber;
            User.UserRole = user.UserRole;
            User.UserToken = user.UserToken;
        }
        
    }
}
