using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerLogic.Data.DataModels;
using ServerLogic.Data.ModelRepository.ChatRepository;

namespace MessangerTests
{
    [TestClass]
    public class ChatRepositoryTest
    {
        Chat chat = new Chat();
        
        public ChatRepositoryTest()
        {
            chat.ChatId = 3;
            chat.ChatName = "GroupChatFor4";
            chat.ChatStatus ="4";
            chat.ChatType ="group";

        }
        [TestMethod]
        public void CheckGetItem()
        {
            //arange
            Chat real;
            //action
            using (ChatRepository repository = new ChatRepository())
            {
                real = repository.GetItem(chat.ChatId);
            }
            //assert
            Assert.AreEqual(chat.ChatId, real.ChatId);
        }
        [TestMethod]
        public void CheckGetItemList_first()
        {
            //arange
            Chat real;
            //action
            using (ChatRepository repository = new ChatRepository())
            {
                var list = repository.GetItemList();
                real = list.Where(d => d.ChatId == chat.ChatId).First();
            }
            //assert
            Assert.AreEqual(chat.ChatId, real.ChatId);
        }
    }
}
