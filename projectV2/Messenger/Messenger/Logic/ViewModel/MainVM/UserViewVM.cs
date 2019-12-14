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
    /// <summary>
    /// View model for user view
    /// </summary>
    public class UserViewVM : BaseVM
    {
        private AccountModel _accountModel;
        /// <summary>
        /// account model that you can see on view
        /// </summary>
        public AccountModel AccountModel
        {
            get => _accountModel;
            set
            {
                _accountModel = value;
                OnPropertyChanged("AccountModel");
            }
        }
        /// <summary>
        /// Command on btn
        /// </summary>
        public ICommand OpenUserInfoCommand { get; private set; }
        /// <summary>
        /// ctor
        /// </summary>
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
