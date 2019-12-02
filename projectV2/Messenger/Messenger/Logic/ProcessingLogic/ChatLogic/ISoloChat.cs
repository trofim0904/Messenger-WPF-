using Messenger.Data.DataModels;
using Messenger.Logic.Models;
using Messenger.Presentation.View.Main.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Logic.ProcessingLogic.ChatLogic
{
    public interface ISoloChat
    {
        IEnumerable<ChatLookUC> GetSoloChatUC(User user);
        ChatModel GetOrCreateChat(AccountModel user);

    }
}
