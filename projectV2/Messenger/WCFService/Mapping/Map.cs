using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService.Data.DataModels;
using WCFService.Logic.Models;

namespace WCFService.Mapping
{
    public class Map : IMainMap, IMapUser
    {
        public ChatDTO ChatToChatDTO(Chat chat)
        {
            ChatDTO chatDTO = new ChatDTO
            {
                Id = chat.ChatId,
                Img = chat.ChatImg,
                Name = chat.ChatName,
                Status = chat.ChatStatus,
                

            };
            return chatDTO;
        }
        public MessageDTO MessageToMessageDTO(Message message)
        {
            MessageDTO messageDTO = new MessageDTO()
            {
                Id = message.MesId,
                Text = message.MesText,
                Time = message.MesTime,
                UserId = message.MesUserId
            };
            return messageDTO;
        }
        public LoginModel LoginDTOToLoginModel(LoginDTO loginDTO)
        {
            LoginModel login = new LoginModel()
            {
                Username = loginDTO.Username,
                Password = loginDTO.Password
            };
            return login;
        }

        public AccountDTO UserToAccountDTO(User user)
        {
            AccountDTO accountDTO = new AccountDTO()
            {
                Id = user.UserId,
                Email = user.UserEmail,
                Login = user.UserLogin,
                Img = user.UserImg,
                Password = user.UserPassword,
                PhoneNumber = user.UserPhoneNumber,
                Role = user.UserRole,

            };
            return accountDTO;
            
        }

        public AccountModel UserToAccountModel(User user)
        {
            AccountModel account = null;
            if (user != null)
            {
                account = new AccountModel()
                {
                    Id = user.UserId,
                    Email = user.UserEmail,
                    Login = user.UserLogin,
                    Img = user.UserImg,
                    Password = user.UserPassword,
                    PhoneNumber = user.UserPhoneNumber,
                    Role = user.UserRole,

                };
            }
            return account;
        }

        public AccountModel AccountDTOToAccountModel(AccountDTO accountDTO)
        {
            AccountModel account = new AccountModel()
            {
                Id = accountDTO.Id,
                Email = accountDTO.Email,
                Login = accountDTO.Login,
                Img = accountDTO.Img,
                Password = accountDTO.Password,
                PhoneNumber = accountDTO.PhoneNumber,
                Role = accountDTO.Role,

            };
            return account;
        }

        public RegistrationModel RegistrationDTOToRegistrationModel(RegistrationDTO registrationDTO)
        {
            RegistrationModel registrationModel = new RegistrationModel
            {
                Email = registrationDTO.Email,
                Login = registrationDTO.Login,
                Password = registrationDTO.Password,
                PhoneNumber = registrationDTO.PhoneNumber,
                RepeatPassword = registrationDTO.RepeatPassword
            };
            return registrationModel;
        }

        public User RegistrationModelToUser(RegistrationModel registrationModel)
        {
            User user = new User
            {
                UserEmail = registrationModel.Email,
                UserLogin = registrationModel.Login,
                UserPassword = registrationModel.Password,
                UserPhoneNumber = registrationModel.PhoneNumber,
                UserRole = "user"
            };
            return user;
        }

        public DeviceDTO DeviceToDeviceDTO(Device device)
        {
            DeviceDTO deviceDTO = new DeviceDTO
            {
                DeviceId = device.DeviceId,
                DeviceIp = device.DeviceIp,
                DeviceName = device.DeviceName,
                DeviceTime = device.DeviceTime
            };
            return deviceDTO;
        }

        public Device DeviceDTOToDevice(DeviceDTO deviceDTO)
        {
            Device device = new Device
            {
                DeviceId = deviceDTO.DeviceId,
                DeviceIp = deviceDTO.DeviceIp,
                DeviceName = deviceDTO.DeviceName,
                DeviceTime = deviceDTO.DeviceTime
            };
            return device;
        }

        public ChangeModel ChangeDTOToChangeModel(ChangeDTO changeDTO)
        {
            ChangeModel changeModel = new ChangeModel
            {
                Email = changeDTO.Email,
                Img = changeDTO.Img,
                Login = changeDTO.Login,
                NewPassword = changeDTO.NewPassword,
                OldPassword = changeDTO.OldPassword,
                RepeatPassword = changeDTO.RepeatPassword,
                Token = changeDTO.Token
            };
            return changeModel;
        }

        public User ChangeModelToUser(ChangeModel changeModel)
        {
            User user = new User
            {
                UserEmail = changeModel.Email,
                UserImg = changeModel.Img,
                UserLogin = changeModel.Login,
                UserPassword = changeModel.NewPassword,
                UserId = UsersData.UserList.Accounts[changeModel.Token].Id,
                UserPhoneNumber = UsersData.UserList.Accounts[changeModel.Token].PhoneNumber,
                UserRole = UsersData.UserList.Accounts[changeModel.Token].Role
            };
            return user;
        }

        public User AccountModelToUser(AccountModel accountModel)
        {
            User user = new User
            {
                UserEmail = accountModel.Email,
                UserId = accountModel.Id,
                UserImg = accountModel.Img,
                UserLogin = accountModel.Login,
                UserPassword = accountModel.Password,
                UserPhoneNumber = accountModel.PhoneNumber,
                UserRole = accountModel.Role
            };
            return user;
        }

        public GroupChatDTO ChatToGroupChatDTO(Chat chat)
        {
            GroupChatDTO groupChatDTO = new GroupChatDTO
            {
                ChatAdminId = chat.ChatAdminId,
                Id = chat.ChatId,
                Img = chat.ChatImg,
                Name = chat.ChatName,
                Status = chat.ChatStatus,
                Type = chat.ChatType
            };
            return groupChatDTO;
        }

        public Chat ChatDTOToChat(ChatDTO chatDTO)
        {
            Chat chat = new Chat
            {
                ChatId = chatDTO.Id,
                ChatImg = chatDTO.Img,
                ChatName = chatDTO.Name,
                ChatStatus = chatDTO.Status
            };
            return chat;
        }

        public User AccountDTOToUser(AccountDTO accountDTO)
        {
            User user = new User
            {
                UserEmail = accountDTO.Email,
                UserId = accountDTO.Id,
                UserImg = accountDTO.Img,
                UserLogin = accountDTO.Login,
                UserPassword = accountDTO.Password,
                UserPhoneNumber = accountDTO.PhoneNumber,
                UserRole = accountDTO.Role
            };
            return user;
        }
    }
}
