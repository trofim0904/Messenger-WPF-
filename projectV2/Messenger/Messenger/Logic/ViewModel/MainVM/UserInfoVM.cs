using Messenger.Logic.Models;
using Messenger.Logic.ProcessingLogic.ChatLogic;
using Messenger.Presentation.View.Main.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class UserInfoVM : BaseVM
    {
        private AccountModel _accountModel;
        public AccountModel AccountModel
        {
            get => _accountModel;
            set
            {
                _accountModel = value;
                OnPropertyChanged("AccountModel");
            }
        }
        private ISoloChat _soloChat;
        public ICommand OpenOrCreateChatCommand { get; private set; }
        public UserInfoVM(AccountModel item)
        {
            _soloChat = new ChatLogic();
            AccountModel = item;
            OpenOrCreateChatCommand = new DelegateCommand(OpenOrCreateChat);
        }

        private void OpenOrCreateChat(object obj)
        {
            Window window = new WindowForChat();
            ChattingVM chattingVM = new ChattingVM(window, _soloChat.GetOrCreateChat(AccountModel));
            window.DataContext = chattingVM;
            window.Show();
        }
    }
}
