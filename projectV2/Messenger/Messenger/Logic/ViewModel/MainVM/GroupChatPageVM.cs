using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Messenger.Presentation.View.Main.UserControls;
using Messenger.Logic.ProcessingLogic.ChatLogic;
using Messenger.Mapping;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class GroupChatPageVM : BaseVM
    {
        private ObservableCollection<ChatLookUC> _chats;
        public ObservableCollection<ChatLookUC> Chats
        {
            get => _chats;
            set
            {
                _chats = value;
                OnPropertyChanged("Chats");
            }
        }
        IGroupChat _groupChat;

        public GroupChatPageVM()
        {
            
            _groupChat = new ChatLogic();
            Chats = new ObservableCollection<ChatLookUC>(_groupChat.GetGroupChatUC(MyUser.User.UserToken));
        }

        
    }
}
