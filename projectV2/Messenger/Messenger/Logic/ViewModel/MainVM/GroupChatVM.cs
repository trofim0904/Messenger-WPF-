using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Messenger.Logic.Models;
using System.Windows.Input;
using System.Windows;
using Messenger.Presentation.View.Main.Windows;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class GroupChatVM : BaseVM, INotifyPropertyChanged
    {
        GroupChatModel _groupChat;
        public GroupChatModel Chat
        {
            get => _groupChat;
            set
            {
                _groupChat = value;
                OnPropertyChanged("Chat");
            }
        }
        public ICommand OpenChatCommand { get; private set; }
        public GroupChatVM()
        {
            Chat = new GroupChatModel();
            OpenChatCommand = new DelegateCommand(OpenChat);
        }
        private void OpenChat(object obj)
        {
            Window window = new WindowForChat
            {
                Owner = Application.Current.Windows[0]
            };
            ChattingVM chattingVM = new ChattingVM(window, Chat);
            
            window.DataContext = chattingVM;
            window.Show();
        }



    }
}
