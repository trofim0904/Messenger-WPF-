using Messenger.Logic.ViewModel.LoginVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Messenger.Presentation.View.Login.UserControls
{
    /// <summary>
    /// Логика взаимодействия для RegistrationUC.xaml
    /// </summary>
    public partial class RegistrationUC : UserControl
    {
        public RegistrationUC()
        {
            InitializeComponent();
            DataContext = new RegistrationVM();
        }
    }
}
