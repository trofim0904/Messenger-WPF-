using System.Collections.Generic;
using Messenger.Logic.Models;
using Messenger.Mapping;
using Messenger.MessangerService;
using Messenger.Services;

namespace Messenger.Logic.ProcessingLogic.SearchLogic
{
    public class SearchLogic : ISearchLogic
    {
        public IEnumerable<AccountModel> GetUserViewUCs(string teg)
        {
            IService service = new WCFService();
            List<AccountModel> accountModels = new List<AccountModel>();
            IUserMap userMap = new Map();
            IEnumerable<AccountDTO> accountDTOs = service.GetAccountsByTeg(teg, MyUser.User.UserToken);
            foreach (AccountDTO accountDTO in accountDTOs)
            {
                accountModels.Add(userMap.AccountDTOToAccountModel(accountDTO));
            }
            return accountModels;
        }
    }
}
