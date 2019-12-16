using MessageSocketData.SocketObj;
using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.MappingDTOSocket
{
    public class AccountMap : IMapping<AccountDTO, AccountSocket>
    {
        public AccountSocket MapFrom(AccountDTO obj)
        {
            AccountSocket accountSocket = new AccountSocket()
            {
                Email = obj.Email,
                Id = obj.Id,
                Img = obj.Img,
                Login = obj.Login,
                Password = obj.Password,
                PhoneNumber = obj.PhoneNumber,
                Role = obj.Role,
                Token = obj.Token
            };
            return accountSocket;
        }

        public AccountDTO MapTo(AccountSocket obj)
        {
            AccountDTO accountDTO = new AccountDTO()
            {

                Email = obj.Email,
                Id = obj.Id,
                Img = obj.Img,
                Login = obj.Login,
                Password = obj.Password,
                PhoneNumber = obj.PhoneNumber,
                Role = obj.Role,
                Token = obj.Token
            };
            return accountDTO;
        }
    }
}
