using Messenger.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Logic.ProcessingLogic.AccountLogic
{
    public interface IChangeAccLogic
    {
        void ChangeAcc(ChangeModel model);
    }
}
