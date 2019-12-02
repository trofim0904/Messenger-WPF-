using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;
using Messenger.Presentation.View.Login.UserControls;
using System.Windows.Input;

namespace Messenger.Logic.ViewModel.LoginVM
{
    public class NewPasswordVM : BaseVM, INotifyPropertyChanged
    {
        private bool _isEnable;
        private double _opacity;

        UserControl _emailVer;
        UserControl _newPass;

        public bool IsEnable
        {
            get => _isEnable;
            set
            {
                _isEnable = value;
                OnPropertyChanged("IsEnable");
            }
        }
        public double Opacity
        {
            get => _opacity;
            set
            {
                _opacity = value;
                OnPropertyChanged("Opacity");
            }
        }

        ContentControl _content;
        public ContentControl Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }
        }

        public ICommand CheckCodeCommand { get; private set; }
        public ICommand CreateNewPasswordCommand { get; private set; }
        public ICommand InputEmailCommand { get; private set; }

        public NewPasswordVM()
        {
            _emailVer = new EmailVerificationUC();
            _newPass = new NewPasswordUC();
            IsEnable = true;
            Opacity = 0;

            Content = _emailVer;
            CheckCodeCommand = new DelegateCommand(CheckCode);
            CreateNewPasswordCommand = new DelegateCommand(CreateNewPassword);
            InputEmailCommand = new DelegateCommand(InputEmail);
        }

        private void InputEmail(object obj)
        {
            IsEnable = false;
            Opacity = 1;
        }

        private bool Check(object arg)
        {
            return false;
        }

        private void CreateNewPassword(object obj)
        {

            Content = null;
        }

        private void CheckCode(object obj)
        {
            Content = _newPass;
        }

       

    }
}
