using Messenger.Presentation.View.Login.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Messenger.Logic.ViewModel.LoginVM
{
    /// <summary>
    /// Class for navigation on sign window
    /// </summary>
    public class SignNavigation
    {
        readonly UserControl _login;
        readonly UserControl _registration;
        Window window;
        Dictionary<string, UserControl> pages = new Dictionary<string, UserControl>();
        
        /// <summary>
        /// ctor
        /// </summary>
        public SignNavigation(Window window)
        {
            this.window = window;
            _login = new LoginUC(window);
            _registration = new RegistrationUC();
            pages.Add("login", _login);
            pages.Add("registration", _registration);
        }
        /// <summary>
        /// Get the user control by a name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserControl GetPage(string name)
        {
            return pages[name];
        }

        /// <summary>
        /// Close window
        /// </summary>
        public void CloseWindow()
        {
            window.Close();
        }
    }
}
