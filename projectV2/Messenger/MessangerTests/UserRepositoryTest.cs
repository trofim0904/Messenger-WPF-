using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerLogic.Data.DataModels;
using ServerLogic.Data.ModelRepository.UserRepository;

namespace MessangerTests
{
    [TestClass]
    public class UserRepositoryTest
    {
        //arange
        //action
        //assert
        User user = new User();
        public UserRepositoryTest()
        {
            user.UserEmail = "default@";
            user.UserId = 1;
            user.UserLogin = "default";
            user.UserPassword = "default";
            user.UserRole = "user";
            user.UserPhoneNumber = "380000000000";
        }
        [TestMethod]
        public void CheckLoginInDB()
        {
            //arange
            bool expected = true;
            bool real;
            //action
            using (UserRepository repository = new UserRepository())
            {
                real = repository.CheckLogin(user.UserLogin);
            }
            //assert
            Assert.AreEqual(expected, real);
        }
        [TestMethod]
        public void CheckPhoneNumberInDB()
        {
            //arange
            bool expected = true;
            bool real;
            //action
            using (UserRepository repository = new UserRepository())
            {
                real = repository.CheckPhoneNumber(user.UserPhoneNumber);
            }
            //assert
            Assert.AreEqual(expected, real);
        }
        [TestMethod]
        public void CheckGetUserByLP()
        {
            //arange
            User real;
            //action
            using (UserRepository repository = new UserRepository())
            {
                real = repository.GetUserByLoginPassword(user.UserLogin,user.UserPassword);
            }
            //assert
            Assert.AreEqual(user.UserLogin, real.UserLogin);
        }
        [TestMethod]
        public void CheckGetItem()
        {
            //arange
            User real;
            //action
            using (UserRepository repository = new UserRepository())
            {
                real = repository.GetItem(user.UserId);
            }
            //assert
            Assert.AreEqual(user.UserLogin, real.UserLogin);
        }
        [TestMethod]
        public void CheckGetItemList_first()
        {
            //arange
            User real;
            //action
            using (UserRepository repository = new UserRepository())
            {
                var list = repository.GetItemList();
                real = list.First();
            }
            //assert
            Assert.AreEqual(user.UserLogin, real.UserLogin);
        }

    }
}
