﻿using System.Collections.Generic;
using ServerLogic.Data.DataModels;

namespace ServerLogic.Data.ModelRepository.UserRepository
{
    public interface IUserRepository:IRepository<User>
    {
        User GetUserByLoginPassword(string login, string password);
        bool CheckLogin(string email);
        bool CheckPhoneNumber(string number);
        IEnumerable<User> GetUsersByString(string teg, string token);
        IEnumerable<User> GetItemListWithoutUser(User user);

        User GetUserFromChat(Chat chat, string token);


    }
}