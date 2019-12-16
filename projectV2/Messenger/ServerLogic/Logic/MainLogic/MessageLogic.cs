using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessangerDTO;
using ServerLogic.Data.DataModels;
using ServerLogic.Data.ModelRepository.ChatRepository;
using ServerLogic.Data.ModelRepository.UserRepository;
using ServerLogic.Mapping;

namespace ServerLogic.Logic.MainLogic
{
    public class MessageLogic : IMessageLogic
    {
        public IEnumerable<MessageDTO> GetMessages(ChatDTO chatDTO)
        {
            IEnumerable<Message> messages;
            List<MessageDTO> messageDTOs = new List<MessageDTO>();
            IMainMap mainMap = new Map();
            using (ChatRepository repository = new ChatRepository())
            {
                messages = repository.GetMessages(mainMap.ChatDTOToChat(chatDTO));
            }
            using (UserRepository repository = new UserRepository())
            {
                foreach (Message message in messages)
                {
                    MessageDTO messageDTO = new MessageDTO();
                    messageDTO = mainMap.MessageToMessageDTO(message);
                    User user = repository.GetItem(messageDTO.UserId);
                    messageDTO.Author = user.UserLogin;
                    messageDTO.Img = user.UserImg;
                    messageDTOs.Add(messageDTO);
                }
            }

            return messageDTOs;
        }

        public bool SendMessage(ChatDTO chatDTO, string token, string message)
        {

            if (String.IsNullOrWhiteSpace(message))
            {
                return false;
            }
            IMainMap mainMap = new Map();
            using (ChatRepository repository = new ChatRepository())
            {
                repository.AddMessage(mainMap.ChatDTOToChat(chatDTO), message, token);
                repository.Save();
                return true;
            }
            
        }
    }
}
