using Messenger.Logic.ViewModel.LoginVM;
using System.Windows;

namespace Messenger.Presentation.View.Login.Windows
{
    /// <summary>
    /// Логика взаимодействия для Sign.xaml
    /// </summary>
    public partial class Sign : Window
    {
        public Sign()
        {
            InitializeComponent();
            DataContext = new SignVM(this);    
        }
    }
}
