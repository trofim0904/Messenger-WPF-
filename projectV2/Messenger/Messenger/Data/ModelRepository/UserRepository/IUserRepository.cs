using Messenger.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data.ModelRepository.UserRepository
{
    public interface IUserRepository:IRepository<User>
    {
        User GetUserByLoginPassword(string login, string password);
        bool CheckLogin(string email);
        bool CheckPhoneNumber(string number);
        IEnumerable<User> GetUsersByString(string teg);
        IEnumerable<User> GetItemListWithoutUser(User user);
        
    }
}
