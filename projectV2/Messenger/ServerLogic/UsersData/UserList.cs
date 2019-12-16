using System.Collections.Concurrent;
using ServerLogic.Logic.Models;

namespace ServerLogic.UsersData
{
    public class UserList
    {
        static public ConcurrentDictionary<string, AccountModel> Accounts = new ConcurrentDictionary<string, AccountModel>();
    }
}
