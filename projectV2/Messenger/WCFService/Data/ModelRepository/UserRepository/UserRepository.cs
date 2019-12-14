using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WCFService.Data.DataModels;
using WCFService.UsersData;

namespace WCFService.Data.ModelRepository.UserRepository
{
    /// <summary>
    /// User logic (DB)
    /// </summary>
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        
        /// <summary>
        /// Find user by param
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User GetUserByLoginPassword(string login,string password)
        {
            User user = null;
            try
            {
                user = context.Users.Where(
                    l => l.UserLogin == login).Where(
                    p => p.UserPassword == password).First();
            }
            catch { }
            return user;

        }

       
        /// <summary>
        /// ovveride method update to change user info
        /// </summary>
        /// <param name="item"></param>
        public override void Update(User item)
        {
            User user = context.Users.Find(item.UserId);
            user.UserPassword = item.UserPassword;
            user.UserEmail = item.UserEmail;
            user.UserImg = item.UserImg;
            context.SaveChanges();
        }
        /// <summary>
        /// To check is that login in db
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool CheckLogin(string login)
        {
            User user = null;
            try
            {
                user = context.Users.Where(e => e.UserLogin == login).First();
            }
            catch
            {
                return false;
            }
            
            return true;
        }
        /// <summary>
        /// To check is that phone number in db
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool CheckPhoneNumber(string number)
        {
            User user = null;
            try
            {
                user = context.Users.Where(e => e.UserPhoneNumber == number).First();
            }
            catch
            {
                return false;
            }
            
            return true;
        }
        /// <summary>
        /// Get users by a teg
        /// </summary>
        /// <param name="teg"></param>
        /// <returns></returns>
        public IEnumerable<User> GetUsersByString(string teg, string token)
        {
            int i = UserList.Accounts[token].Id;
            return (from u in context.Users
                    where u.UserRole == "user"
                    where u.UserLogin.Contains(teg)
                    where u.UserId != i
                    select u).ToList();
        }
        /// <summary>
        /// Get all users without some user(Need for example for search list)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IEnumerable<User> GetItemListWithoutUser(User user)
        {
            return (from u in context.Users
                   where u.UserRole == "user"
                   where u.UserId != user.UserId
                   select u).ToList();
        }

        public User GetUserFromChat(Chat chat, string token)
        {
            int i = UserList.Accounts[token].Id;
            return (from u in context.Users
                    join uc in context.UsersInChats on u.UserId equals uc.UserId
                    join c in context.Chats on uc.ChatId equals c.ChatId
                    where c.ChatType == "solo"
                    where c.ChatId == chat.ChatId
                    where u.UserId != i
                    select u).First();
        }
    }
}
