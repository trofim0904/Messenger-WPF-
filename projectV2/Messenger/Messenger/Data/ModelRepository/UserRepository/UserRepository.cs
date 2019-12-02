using Messenger.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Messenger.Data.ModelRepository.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        

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

       

        public override void Update(User item)
        {
            User user = context.Users.Find(item.UserId);
            user.UserPassword = item.UserPassword;
            user.UserEmail = item.UserEmail;
            user.UserImg = item.UserImg;
            context.SaveChanges();
        }

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

        public IEnumerable<User> GetUsersByString(string teg)
        {
            return (from u in context.Users
                    where u.UserRole == "user"
                    where u.UserLogin.Contains(teg)
                    where u.UserId != MyUser.User.UserId
                    select u).ToList();
        }

        public IEnumerable<User> GetItemListWithoutUser(User user)
        {
            return (from u in context.Users
                   where u.UserRole == "user"
                   where u.UserId != user.UserId
                   select u).ToList();
        }
    }
}
