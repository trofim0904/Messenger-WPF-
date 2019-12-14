using Messenger.Logic.Models;
using Messenger.Presentation.View.Main.UserControls;
using System.Collections.Generic;

namespace Messenger.Logic.ProcessingLogic.ChatLogic
{
    public interface ISoloChat
    {
        IEnumerable<ChatLookUC> GetSoloChatUC(string token);
        ChatModel GetOrCreateChat(AccountModel user, string token);

    }
}
