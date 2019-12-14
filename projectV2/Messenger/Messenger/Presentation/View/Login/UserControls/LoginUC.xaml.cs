using Messenger.Logic.ViewModel.LoginVM;
using System.Windows;
using System.Windows.Controls;

namespace Messenger.Presentation.View.Login.UserControls
{
    /// <summary>
    /// Логика взаимодействия для LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        public LoginUC(Window window)
        {
            InitializeComponent();
            DataContext = new LoginVM(window);

            #if DEBUG
                _password.Password = "default";
            #endif

        }
    }
}
