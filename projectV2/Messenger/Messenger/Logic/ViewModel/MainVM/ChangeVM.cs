using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Messenger.Logic.Models;
using System.Windows.Input;
using System.Windows.Controls;
using Messenger.Logic.ProcessingLogic.AccountLogic;
using System.Windows;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class ChangeVM : BaseVM, INotifyPropertyChanged
    {
        private ChangeModel _changeModel;
        public ChangeModel ChangeModel
        {
            get => _changeModel;
            set
            {
                _changeModel = value;
                OnPropertyChanged("ChangeModel");
            }
        }
        public ICommand ChangeCommand { get; private set; }
        private IChangeAccLogic _changeAccLogic;
        public ChangeVM()
        {
            _changeAccLogic = new ChangeAccLogic();
            ChangeModel = new ChangeModel
            {
                Login = MyUser.User.UserLogin
            };
            ChangeCommand = new DelegateCommand(Change);
        }

        private void Change(object obj)
        {
            if (!(obj is PasswordBox passwordBox))
            {
                return;
            }
            ChangeModel.OldPassword = passwordBox.Password;
            ChangeModel.NewPassword = passwordBox.Password;
            ChangeModel.RepeatPassword = passwordBox.Password;


            if (_changeAccLogic.ChangeAccount(ChangeModel))
            {
                MessageBox.Show("You update data", "Complete");
            }
            else
            {
                MessageBox.Show("You input wrong data", "Error");
            }

        }

      
    }
}
