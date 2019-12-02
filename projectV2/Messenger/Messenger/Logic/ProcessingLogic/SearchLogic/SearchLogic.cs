using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.Data.DataModels;
using Messenger.Data.ModelRepository.UserRepository;
using Messenger.Logic.Models;
using Messenger.Logic.ViewModel.MainVM;
using Messenger.Presentation.View.Main.UserControls;

namespace Messenger.Logic.ProcessingLogic.SearchLogic
{
    public class SearchLogic : ISearchLogic
    {
        public IEnumerable<UserViewUC> GetUserViewUCs(string teg)
        {
            List<UserViewUC> userViewUCs = new List<UserViewUC>();
            IEnumerable<User> users;
            if (teg == null)
            {
                
                using (UserRepository repository = new UserRepository())
                {
                    users = repository.GetItemListWithoutUser(MyUser.User);
                    
                }
                
            }
            else
            {
                using (UserRepository repository = new UserRepository())
                {
                    users = repository.GetUsersByString(teg);
                }
            }

            foreach (User user in users)
            {
                if (user.UserRole.Equals("user"))
                {
                    UserViewVM userVM = new UserViewVM();
                    UserViewUC viewUC = new UserViewUC();
                    userVM.AccountModel.AccountId = user.UserId;
                    userVM.AccountModel.AccountEmail = user.UserEmail;
                    userVM.AccountModel.AccountImg = user.UserImg;
                    userVM.AccountModel.AccountLogin = user.UserLogin;
                    userVM.AccountModel.AccountPhoneNumber = user.UserPhoneNumber;
                    viewUC.DataContext = userVM;

                    userViewUCs.Add(viewUC);

                }


            }
            return userViewUCs;
        }
    }
}
