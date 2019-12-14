using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Threading;
using System.Windows;

namespace Messenger.Logic.ViewModel.LoginVM
{
    public class SignVM : BaseVM
    {
        //private Window _signWindow;
        ContentControl _content;
        private double _contentOpacity;

        //private UserControl _login;
        //private UserControl _registration;

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
        private SignNavigation navigation;


        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="window"></param>
        public SignVM(Window window)
        {
            navigation = new SignNavigation(window);
            //_signWindow = window;
            //_login = new LoginUC(_signWindow);
            //_registration = new RegistrationUC();


            Content = navigation.GetPage("login");
            ContentOpacity = 1.0;


            GoToRegistrationCommand = new DelegateCommand(GoToRegistration);
            GoToLoginCommand = new DelegateCommand(GoToLogin);
           
        }

        private void GoToLogin(object obj)
        {
            SlowOpacity(navigation.GetPage("login"));
        }

        private void GoToRegistration(object obj)
        {
            SlowOpacity(navigation.GetPage("registration"));
           
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
