using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Messenger.Presentation.View.Login.Windows;
using System.Windows.Controls;
using Messenger.Presentation.View.Admin.Pages;

namespace Messenger.Logic.ViewModel.AdminVM
{
    public class AdminWindowVM : BaseVM, INotifyPropertyChanged
    {
        Window window;
        Page _message;
        Page _search;

        private Page _adminContent;
        public Page AdminContent
        {
            get => _adminContent;
            set
            {
                _adminContent = value;
                OnPropertyChanged("AdminContent");
            }
        }


        public ICommand GoToSearchCommand { get; private set; }
        public ICommand GoToMessageCommand { get; private set; }
        public ICommand ExitCommand { get; private set; }

        public AdminWindowVM(Window window)
        {
            this.window = window;
            _message = new MessageToAll();
            _search = new Search();
            AdminContent = _message;
            GoToMessageCommand = new DelegateCommand(GoToMessage, CanGoToMessage);
            GoToSearchCommand = new DelegateCommand(GoToSearch, CanGoToSearch);
            ExitCommand = new DelegateCommand(Exit);

            
        }

        private bool CanGoToSearch(object arg)
        {
            return !((AdminContent) is Search);
        }

        private bool CanGoToMessage(object arg)
        {
            return !((AdminContent) is MessageToAll);
        }

        private void Exit(object obj)
        {
            Window sign = new Sign();
            sign.Show();
            window.Close();
        }

        private void GoToSearch(object obj)
        {
            AdminContent = _search;
        }

        private void GoToMessage(object obj)
        {
            AdminContent = _message;
        }

       
    }
}
