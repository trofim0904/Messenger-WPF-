using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Messenger.Logic.Models;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Controls;
using Messenger.Logic.ProcessingLogic.SignLogic;
using System.Windows;

namespace Messenger.Logic.ViewModel.LoginVM
{
    class RegistrationVM : BaseVM, INotifyPropertyChanged
    {
        private RegistrationModel _registrationmodel;
        private bool _isCheckBoxChecked;

        public bool IsCheckBoxChecked
        {
            get => _isCheckBoxChecked;
            set
            {
                _isCheckBoxChecked = value;
                OnPropertyChanged("IsCheckBoxChecked");
            }
        }



        public RegistrationModel RegistrationModel
        {
            get
            {
                return _registrationmodel;
            }
            set
            {
                _registrationmodel = value;
                OnPropertyChanged("RegistrationModel");
            }
        }

        public ICommand RegistrationCommand { get; private set; }
        private IRegistration _registration;

        public RegistrationVM()
        {
            RegistrationModel = new RegistrationModel();
            RegistrationCommand = new DelegateCommand(Registration, CanRegistr);
            
        }

        private bool CanRegistr(object arg)
        {
            return IsCheckBoxChecked;
        }

        private void Registration(object obj)
        {
            if (!(obj is PasswordBox passwordBox))
                return;
            RegistrationModel.Password = passwordBox.Password;
            RegistrationModel.RepeatPassword = passwordBox.Password;

            _registration = new Registration();

            if (_registration.GetRegistred(RegistrationModel))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

      
    }
}
