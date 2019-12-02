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
    public class SoloChatVM : BaseVM, INotifyPropertyChanged
    {

        private ChatModel _chatModel;
        public ChatModel Chat
        {
            get => _chatModel;
            set
            {
                _chatModel = value;
                OnPropertyChanged("Chat");
            }
        }

        public ICommand OpenChatCommand { get; private set; }
        

        public SoloChatVM()
        {
            Chat = new ChatModel();
            OpenChatCommand = new DelegateCommand(OpenChat);
        }

        private void OpenChat(object obj)
        {
            Window window = new WindowForChat();
            ChattingVM chattingVM = new ChattingVM(window, Chat);
            //chattingVM.ChatModel = Chat;////////////////////////////////////////////////////////////
            window.DataContext = chattingVM;
            window.Show();
        }

       
    }
}
