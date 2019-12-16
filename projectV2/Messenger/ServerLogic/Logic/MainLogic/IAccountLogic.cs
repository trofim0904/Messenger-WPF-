using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Logic.MainLogic
{
    public interface IAccountLogic
    {
        bool ChangeAccount(ChangeDTO changeDTO);
        IEnumerable<AccountDTO> GetAccountsByTeg(string teg, string token);
    }
}
