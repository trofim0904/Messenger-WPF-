using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Messenger.Logic.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Messenger.Presentation.View.Main.UserControls;
using Messenger.Logic.ProcessingLogic.ChatLogic;
using Messenger.Data;

namespace Messenger.Logic.ViewModel.MainVM
{
    class ChattingVM : BaseVM
    {
        private string _messText;
        private ChatModel _chatModel;
        private Window _chattingWindow;
        private ObservableCollection<MessageUC> _messages;
        public ChatModel ChatModel
        {
            get => _chatModel;
            set
            {
                _chatModel = value;
                OnPropertyChanged("ChatModel");
            }
        }
        public ObservableCollection<MessageUC> Messages
        {
            get => _messages;
            set
            {
                _messages = value;
                OnPropertyChanged("Messages");
            }
        }
        public string MessText
        {
            get => _messText;
            set
            {
                _messText = value;
                OnPropertyChanged("MessText");
            }
        }
        private IChattingLogic _chattingLogic; 
        public ICommand SendMessageCommand { get; private set; }
        public ICommand ExitCommand { get; private set; }

        public ChattingVM(Window window, ChatModel chat)
        {
            _chattingLogic = new ChatLogic();
            ChatModel = chat;
            _chattingWindow = window;
            Messages = new ObservableCollection<MessageUC>(_chattingLogic.GetMessages(ChatModel));
          

            SendMessageCommand = new DelegateCommand(SendMessage);
            ExitCommand = new DelegateCommand(Exit);
        }

        private void SendMessage(object obj)
        {
            _chattingLogic.SendMessage(ChatModel, obj as string);
            Messages = new ObservableCollection<MessageUC>(_chattingLogic.GetMessages(ChatModel));
            MessText = null;
        }

        private void Exit(object obj)
        {
            _chattingWindow.Close();
        }

        
    }
}
