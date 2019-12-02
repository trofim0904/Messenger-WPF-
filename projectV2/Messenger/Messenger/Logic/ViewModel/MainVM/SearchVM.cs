using Messenger.Logic.Models;
using Messenger.Logic.ProcessingLogic.SearchLogic;
using Messenger.Presentation.View.Main.UserControls;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class SearchVM : BaseVM
    {
        private string _textsearch;
        public string TextSearch
        {
            get => _textsearch;
            set
            {
                _textsearch = value;
                OnPropertyChanged("TextSearch");
            }
        }
        private ObservableCollection<UserViewUC> _users;
        public ObservableCollection<UserViewUC> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }
        private ISearchLogic _searchLogic;
        public ICommand SearchCommand { get; private set; }
        public SearchVM()
        {
            _searchLogic = new SearchLogic();
            Users = new ObservableCollection<UserViewUC>(_searchLogic.GetUserViewUCs(null));
            SearchCommand = new DelegateCommand(SearchUsers);
        }

        private void SearchUsers(object obj)
        {
            Users = new ObservableCollection<UserViewUC>(_searchLogic.GetUserViewUCs(TextSearch));
        }
    }
}
