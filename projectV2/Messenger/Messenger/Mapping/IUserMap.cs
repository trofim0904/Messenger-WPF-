using Messenger.Logic.Models;
using Messenger.MessangerService;

namespace Messenger.Mapping
{
    public interface IUserMap
    {
        //User UserModelToUser(UserModel userModel);

        ChangeDTO ChangeModelToChangeDTO(ChangeModel changeModel);

        AccountModel AccountDTOToAccountModel(AccountDTO accountDTO);

        AccountDTO AccountModelToAccountDTO(AccountModel accountModel);
    }
}
