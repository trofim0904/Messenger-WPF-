using Messenger.Logic.ViewModel.AdminVM;
using System.Windows;

namespace Messenger.Presentation.View.Admin.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            DataContext = new AdminWindowVM(this);
        }
    }
}
