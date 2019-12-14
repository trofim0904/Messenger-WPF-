using Messenger.Data.DataModels;
using Messenger.Logic.Models;
using Messenger.MessangerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Mapping
{
    public interface IUserMap
    {
        User UserModelToUser(UserModel userModel);

        ChangeDTO ChangeModelToChangeDTO(ChangeModel changeModel);

        AccountModel AccountDTOToAccountModel(AccountDTO accountDTO);

        AccountDTO AccountModelToAccountDTO(AccountModel accountModel);
    }
}
