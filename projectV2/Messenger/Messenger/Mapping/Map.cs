using Messenger.Logic.Models;
using Messenger.MessangerService;

namespace Messenger.Mapping
{
    public class Map : ISignMap, IUserMap, IChatMap
    {
        public AccountModel AccountDTOToAccountModel(AccountDTO accountDTO)
        {
            AccountModel accountModel = new AccountModel
            {
                AccountId = accountDTO.Id,
                AccountEmail = accountDTO.Email,
                AccountImg = accountDTO.Img,
                AccountLogin = accountDTO.Login,
                AccountPhoneNumber = accountDTO.PhoneNumber
            };
            return accountModel;
        }

        public UserModel AccountDTOToUserModel(AccountDTO accountDTO)
        {
            UserModel userModel = new UserModel
            {
                UserEmail = accountDTO.Email,
                UserId = accountDTO.Id,
                UserImg = accountDTO.Img,
                UserLogin = accountDTO.Login,
                UserPassword = accountDTO.Password,
                UserPhoneNumber = accountDTO.PhoneNumber,
                UserRole = accountDTO.Role,
                UserToken = accountDTO.Token
            };
            return userModel;

        }

        public AccountDTO AccountModelToAccountDTO(AccountModel accountModel)
        {
            AccountDTO accountDTO = new AccountDTO
            {
                Email = accountModel.AccountEmail,
                Id = accountModel.AccountId,
                Img = accountModel.AccountImg,
                Login = accountModel.AccountLogin,
                PhoneNumber = accountModel.AccountPhoneNumber
            };
            return accountDTO;
        }

        public ChangeDTO ChangeModelToChangeDTO(ChangeModel changeModel)
        {
            ChangeDTO changeDTO = new ChangeDTO
            {
                Token = MyUser.User.UserToken,
                Email = changeModel.Email,
                Img = changeModel.Img,
                Login = changeModel.Login,
                NewPassword = changeModel.NewPassword,
                OldPassword = changeModel.OldPassword,
                RepeatPassword = changeModel.RepeatPassword
            };

            return changeDTO;
        }

        public ChatModel ChatDTOToChatModel(ChatDTO chatDTO)
        {
            ChatModel chatModel = new ChatModel
            {
                Id = chatDTO.Id,
                Img = chatDTO.Img,
                Name = chatDTO.Name,
                Status = chatDTO.Status
            };
            return chatModel;
        }

        public ChatDTO ChatModelToChatDTO(ChatModel chatModel)
        {
            ChatDTO chatDTO = new ChatDTO
            {
                Id = chatModel.Id,
                Img = chatModel.Img,
                Name = chatModel.Name,
                Status = chatModel.Status,
                

            };
            return chatDTO;
        }

        public LoginDTO LoginModelToLoginDTO(LoginModel model)
        {
            LoginDTO loginDTO = new LoginDTO
            {
                Username = model.Username,
                Password = model.Password
            };
            return loginDTO;
        }

        public RegistrationDTO RegistrationModelToRegistrationDTO(RegistrationModel registrationModel)
        {
            RegistrationDTO registrationDTO = new RegistrationDTO
            {
                Email = registrationModel.Email,
                Login = registrationModel.Login,
                Password = registrationModel.Password,
                PhoneNumber = registrationModel.PhoneNumber,
                RepeatPassword = registrationModel.RepeatPassword
            };
            return registrationDTO;
        }

      
    }
}
