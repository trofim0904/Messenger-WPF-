using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;
using System.Threading;
using Messenger.Presentation.View.Main.Pages;
using System.Windows.Input;
using System.Windows;
using Messenger.Presentation.View.Login.Windows;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class MainVM : BaseVM, INotifyPropertyChanged
    {
        private Window _mainWindow;
        private Page _account;
        private Page _chat;
        private Page _groupChat;
        private Page _device;
        private Page _search;
        private Page _about;
        private Page _change;



        private Page _mainContent;
        private double _mainContentOpacity;

        public Page MainContent
        {
            get => _mainContent;
            set
            {
                _mainContent = value;
                OnPropertyChanged("MainContent");
            }
        }
        public double MainContentOpacity
        {
            get => _mainContentOpacity;
            set
            {
                _mainContentOpacity = value;
                OnPropertyChanged("MainContentOpacity");
            }
        }

        public ICommand AccountPageCommand { get; private set; }
        public ICommand ChangePageCommand { get; private set; }
        public ICommand AboutPageCommand { get; private set; }
        public ICommand ChatPageCommand { get; private set; }
        public ICommand GroupChatPageCommand { get; private set; }
        public ICommand SearchPageCommand { get; private set; }
        public ICommand DevicePageCommand { get; private set; }
        public ICommand ExitCommand { get; private set; }

        public MainVM(Window window)
        {
            _account = new AccountPage();
            _about = new AboutPage();
            _chat = new ChatPage();
            _groupChat = new GroupChatPage();
            _search = new SearchPage();
            _device = new DevicePage();
            _change = new ChangePage();
            _mainWindow = window;

            MainContent = _account;
            MainContentOpacity = 1;

            AccountPageCommand = new DelegateCommand(AccountPageOpen);
            AboutPageCommand = new DelegateCommand(AboutPageOpen);
            ChatPageCommand = new DelegateCommand(ChatPageOpen);
            GroupChatPageCommand = new DelegateCommand(GroupChatPageOpen);
            SearchPageCommand = new DelegateCommand(SearchPageOpen);
            DevicePageCommand = new DelegateCommand(DevicePageOpen);
            ChangePageCommand = new DelegateCommand(ChangePageOpen);
            ExitCommand = new DelegateCommand(Exit);
        }

        private void ChangePageOpen(object obj)
        {
            SlowOpacity(_change);
        }

        private void Exit(object obj)
        {
            Window window = new Sign();
            window.Show();
            _mainWindow.Close();
        }

        private void DevicePageOpen(object obj)
        {
            SlowOpacity(_device);
        }

        private void SearchPageOpen(object obj)
        {
            SlowOpacity(_search);
        }

        private void GroupChatPageOpen(object obj)
        {
            SlowOpacity(_groupChat);
        }

        private void ChatPageOpen(object obj)
        {
            SlowOpacity(_chat);
        }

        private void AboutPageOpen(object obj)
        {
            SlowOpacity(_about);
        }

        private void AccountPageOpen(object obj)
        {
         
            SlowOpacity(_account);
        }

        

        private async void SlowOpacity(Page control)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0.0; i -= 0.1)
                {
                    MainContentOpacity = i;
                    Thread.Sleep(50);
                }
                MainContent = control;

                for (double i = 0.0; i < 1.1; i += 0.1)
                {
                    MainContentOpacity = i;
                    Thread.Sleep(50);
                }
            });
        }
    }
}
