using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessangerDTO;
using ServerLogic.Data.DataModels;
using ServerLogic.Data.ModelRepository.UserRepository;
using ServerLogic.Logic.Models;
using ServerLogic.Mapping;

namespace ServerLogic.Logic.MainLogic
{
    public class AccountLogic : IAccountLogic
    {
        public bool ChangeAccount(ChangeDTO changeDTO)
        {
            IMainMap map = new Map();
            ChangeModel model = map.ChangeDTOToChangeModel(changeDTO);
            if (model.Img == null)
            {

                return false;
            }
            if (model.Email == null)
            {

                return false;
            }
            if (model.NewPassword == null)
            {

                return false;
            }
            if (model.OldPassword == null)
            {

                return false;
            }
            if (model.RepeatPassword == null)
            {

                return false;
            }
            if (model.NewPassword != model.RepeatPassword)
            {

                return false;
            }
            if (model.OldPassword != UsersData.UserList.Accounts[model.Token].Password)
            {

                return false;
            }
            using (UserRepository repository = new UserRepository())
            {
                IMapUser mapSign = new Map();
                repository.Update(map.ChangeModelToUser(model));
                repository.Save();
                UsersData.UserList.Accounts[model.Token] = mapSign.UserToAccountModel(map.ChangeModelToUser(model));
                return true;
            }
        }

        public IEnumerable<AccountDTO> GetAccountsByTeg(string teg, string token)
        {
            IMainMap map = new Map();
            List<AccountDTO> accounts = new List<AccountDTO>();
            IEnumerable<User> users;
            if (teg == null)
            {
                
                using (UserRepository repository = new UserRepository())
                {
                    users = repository.GetItemListWithoutUser(map.AccountModelToUser(UsersData.UserList.Accounts[token]));

                }

            }
            else
            {
                using (UserRepository repository = new UserRepository())
                {
                    users = repository.GetUsersByString(teg, token);
                }
            }
            IMapUser accountmap = new Map();
            foreach (User user in users)
            { 
                accounts.Add(accountmap.UserToAccountDTO(user));
            }
            return accounts;
        }
    }
}
