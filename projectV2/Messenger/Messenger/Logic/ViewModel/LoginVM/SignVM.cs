using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using Messenger.Presentation.View.Login.UserControls;
using System.Threading;
using System.Windows;

namespace Messenger.Logic.ViewModel.LoginVM
{
    public class SignVM : BaseVM, INotifyPropertyChanged
    {
        private Window _signWindow;
        ContentControl _content;
        private double _contentOpacity;

        private UserControl _login;
        private UserControl _registration;

        public double ContentOpacity
        {
            get
            {
                return _contentOpacity;
            }
            set
            {
                _contentOpacity = value;
                OnPropertyChanged("ContentOpacity");
            }
        }

        public ContentControl Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }
        }

        public ICommand GoToLoginCommand { get; private set; }
        public ICommand GoToRegistrationCommand { get; private set; }
        

        public SignVM(Window window)
        {
            _signWindow = window;
            _login = new LoginUC(_signWindow);
            _registration = new RegistrationUC();
            

            Content = _login;
            ContentOpacity = 1.0;


            GoToRegistrationCommand = new DelegateCommand(GoToRegistration);
            GoToLoginCommand = new DelegateCommand(GoToLogin);
           
        }

        private void GoToLogin(object obj)
        {
            SlowOpacity(_login);
        }

        private void GoToRegistration(object obj)
        {
            SlowOpacity(_registration);
            //Content = _registration;
        }

        

        private async void SlowOpacity(UserControl control) 
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0.0; i -= 0.1)
                {
                    ContentOpacity = i;
                    Thread.Sleep(50);
                }
                Content = control;
                
                for (double i = 0.0; i < 1.1; i += 0.1)
                {
                    ContentOpacity = i;
                    Thread.Sleep(50);
                }
            });
        }
    }
}
