using Messenger.Logic.Models;
using System.Collections.Generic;

namespace Messenger.Logic.ProcessingLogic.SearchLogic
{
    public interface ISearchLogic
    {
        IEnumerable<AccountModel> GetUserViewUCs(string teg);
    }
}
