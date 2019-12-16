using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerLogic.Data.DataModels;
using ServerLogic.Data.ModelRepository.MessageRepository;

namespace MessangerTests
{
    [TestClass]
    public class MessageRepositoryTest
    {
        Message message = new Message();
        public MessageRepositoryTest()
        {
            message.MesId = 12;
            message.MesText = "hi";
            message.MesTime = "20:27";
            message.MesUserId = 1;
        }

        [TestMethod]
        public void CheckGetItem()
        {
            //arange
            Message real;
            //action
            using (MessageRepository repository = new MessageRepository())
            {
                real = repository.GetItem(message.MesId);
            }
            //assert
            Assert.AreEqual(message.MesId, real.MesId);
        }
        [TestMethod]
        public void CheckGetItemList_first()
        {
            //arange
            Message real;
            //action
            using (MessageRepository repository = new MessageRepository())
            {
                var list = repository.GetItemList();
                real = list.Where(d => d.MesId == message.MesId).First();
            }
            //assert
            Assert.AreEqual(message.MesId, real.MesId);
        }
    }
}
