using Messenger.Logic.Models;
using Messenger.Logic.ProcessingLogic.SearchLogic;
using Messenger.Presentation.View.Main.UserControls;
using System.Collections.Generic;
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
            Users = new ObservableCollection<UserViewUC>(GetUserViewUCList(_searchLogic.GetUserViewUCs(null)));
            SearchCommand = new DelegateCommand(SearchUsers);
        }

        private void SearchUsers(object obj)
        {
            Users = new ObservableCollection<UserViewUC>(GetUserViewUCList(_searchLogic.GetUserViewUCs(TextSearch)));
        }

        private UserViewUC AccountToUC(AccountModel accountModel)
        {
            UserViewVM userVM = new UserViewVM();
            UserViewUC viewUC = new UserViewUC();
            userVM.AccountModel.AccountId = accountModel.AccountId;
            userVM.AccountModel.AccountEmail = accountModel.AccountEmail;
            userVM.AccountModel.AccountImg = accountModel.AccountImg;
            userVM.AccountModel.AccountLogin = accountModel.AccountLogin;
            userVM.AccountModel.AccountPhoneNumber = accountModel.AccountPhoneNumber;
            viewUC.DataContext = userVM;

            return viewUC;
        }
        private IEnumerable<UserViewUC> GetUserViewUCList(IEnumerable<AccountModel> accounts)
        {
            if (accounts != null)
            {
                List<UserViewUC> list = new List<UserViewUC>();
                foreach (AccountModel account in accounts)
                {
                    list.Add(AccountToUC(account));
                }
                return list;
            }
            return null;
        }
    }
}
