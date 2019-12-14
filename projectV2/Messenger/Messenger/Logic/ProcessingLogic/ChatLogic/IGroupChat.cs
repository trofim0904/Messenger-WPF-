using Messenger.Presentation.View.Main.UserControls;
using System.Collections.Generic;

namespace Messenger.Logic.ProcessingLogic.ChatLogic
{
    public interface IGroupChat
    {
        IEnumerable<ChatLookUC> GetGroupChatUC(string token);
    }
}
