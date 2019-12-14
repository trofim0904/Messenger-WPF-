using Messenger.Logic.Models;
using Messenger.Logic.ProcessingLogic.SignLogic;
using Messenger.Presentation.View.Admin.Windows;
using Messenger.Presentation.View.Login.UserControls;
using Messenger.Presentation.View.Login.Windows;
using Messenger.Presentation.View.Main.Windows;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Messenger.Logic.ViewModel.LoginVM
{
    public class LoginVM : BaseVM, INotifyPropertyChanged
    {
        private Window _signWindow;
        

        private LoginModel _loginmodel;
        public LoginModel LoginModel
        {
            get
            {
                return _loginmodel;
            }
            set
            {
                _loginmodel = value;
                OnPropertyChanged("LoginModel");
            }
        }

        

        public ICommand SignInCommand { get;private set; }
        public ICommand ForgotPasswordCommand { get; private set; }
        private ILogin _login;

        public LoginVM(Window window)
        {
            _signWindow = window;
            SignInCommand = new DelegateCommand(SignIn);
            ForgotPasswordCommand = new DelegateCommand(ForgotPassword);
            LoginModel = new LoginModel();
#if DEBUG
            LoginModel.Username = "default";            
#endif

        }

        private void ForgotPassword(object obj)
        {
            Window window = new NewPassword();
            window.Show();
        }

       

        private void SignIn(object obj)
        {
            if (!(obj is PasswordBox passwordBox))
                return;
            LoginModel.Password = passwordBox.Password;



            _login = new Login();

            if (_login.GetLogin(LoginModel))
            {
                if (MyUser.User.UserRole.Equals("user"))
                {
                    Window window = new Main();
                    window.Show();
                }
                if (MyUser.User.UserRole.Equals("admin"))
                {
                    Window window = new AdminWindow();
                    window.Show();
                }
                _signWindow.Close();
                
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

      
    }
}
