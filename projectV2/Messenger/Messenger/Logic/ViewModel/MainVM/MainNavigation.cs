using Messenger.Presentation.View.Main.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;


namespace Messenger.Logic.ViewModel.MainVM
{
    /// <summary>
    /// Class for navigation for main window
    /// </summary>
    public class MainNavigation
    {

        Dictionary<string, Page> pages = new Dictionary<string, Page>();

        //private Window _mainWindow;
        private readonly Page _account;
        private readonly Page _chat;
        private readonly Page _groupChat;
        private readonly Page _device;
        private readonly Page _search;
        private readonly Page _about;
        private readonly Page _change;
        /// <summary>
        /// ctor
        /// </summary>
        public MainNavigation(/*Window window*/)
        {
            _account = new AccountPage();
            _about = new AboutPage();
            _chat = new ChatPage();
            _groupChat = new GroupChatPage();
            _search = new SearchPage();
            _device = new DevicePage();
            _change = new ChangePage();

            pages.Add("account", _account);
            pages.Add("about", _about);
            pages.Add("chat", _chat);
            pages.Add("groupChat", _groupChat);
            pages.Add("search", _search);
            pages.Add("device", _device);
            pages.Add("change", _change);

            //_mainWindow = window;
        }

        /// <summary>
        /// Return page by a name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Page GetPage(string name)
        {
            return pages[name];
        }
        public void CloseWindow()
        {
            //_mainWindow.Close();
            //Application.Current.MainWindow.Close();
            WindowCollection windows = Application.Current.Windows;
            foreach(Window window in windows)
            {
                if (window.Name.Equals("MainWindow"))
                {
                    window.Close();
                }
            }

        }

    }
}
