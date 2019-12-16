using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Logic.MainLogic
{
    public interface IChatLogic<T> where T:class
    {
        IEnumerable<T> GetChats(string token);
        T GetOrCreateChat(AccountDTO accountDTO, string token);


    }
}
