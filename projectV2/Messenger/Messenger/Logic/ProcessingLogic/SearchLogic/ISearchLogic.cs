using Messenger.Presentation.View.Main.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Logic.ProcessingLogic.SearchLogic
{
    public interface ISearchLogic
    {
        IEnumerable<UserViewUC> GetUserViewUCs(string teg);
    }
}
