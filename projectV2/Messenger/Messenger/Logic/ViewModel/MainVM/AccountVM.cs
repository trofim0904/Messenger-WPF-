using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Messenger.Logic.Models;
using Messenger.Logic.ProcessingLogic.AccountLogic;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class AccountVM : BaseVM, INotifyPropertyChanged
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
        private IInfoLogic InfoLogic;
        public AccountVM()
        {
            InfoLogic = new InfoLogic();
            AccountModel = InfoLogic.GetAccount();
            
        }

     
    }
}
