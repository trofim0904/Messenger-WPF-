using Messenger.Logic.Models;
using Messenger.Presentation.View.Main.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Logic.ProcessingLogic.ChatLogic
{
    public interface IChattingLogic
    {
        IEnumerable<MessageUC> GetMessages(ChatModel chatModel);
        void SendMessage(ChatModel chatModel, string mess);
    }
}
