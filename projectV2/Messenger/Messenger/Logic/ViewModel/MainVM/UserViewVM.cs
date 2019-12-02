using Messenger.Logic.Models;
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
    public class UserViewVM : BaseVM
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
        public ICommand OpenUserInfoCommand { get; private set; }
        public UserViewVM()
        {
            AccountModel = new AccountModel();
            OpenUserInfoCommand = new DelegateCommand(OpenUserInfo);
        }

        private void OpenUserInfo(object obj)
        {
            Window window = new UserInfoWindow();
            UserInfoVM userInfoVM = new UserInfoVM(AccountModel);
            window.DataContext = userInfoVM;
            window.Show();
        }
    }
}
