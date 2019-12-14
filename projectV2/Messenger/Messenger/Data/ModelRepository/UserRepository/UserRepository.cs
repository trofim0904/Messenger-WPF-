using Messenger.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Messenger.Data.ModelRepository.UserRepository
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
            catch
            {
                MessageBox.Show("Wrong login or password", "Error");
            }
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
        public IEnumerable<User> GetUsersByString(string teg)
        {
            return (from u in context.Users
                    where u.UserRole == "user"
                    where u.UserLogin.Contains(teg)
                    where u.UserId != MyUser.User.UserId
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
    }
}
