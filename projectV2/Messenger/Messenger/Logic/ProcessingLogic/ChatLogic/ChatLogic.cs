using System.Collections.Generic;
using System.Windows;
using Messenger.Logic.Models;
using Messenger.Logic.ViewModel.MainVM;
using Messenger.Mapping;
using Messenger.MessangerService;
using Messenger.Presentation.View.Main.UserControls;
using Messenger.Services;

namespace Messenger.Logic.ProcessingLogic.ChatLogic
{
    public class ChatLogic : ISoloChat, IGroupChat, IChattingLogic
    {
        public IEnumerable<ChatLookUC> GetGroupChatUC(string token)
        {
            List<ChatLookUC> groupChatUCs = new List<ChatLookUC>();
            
            IService service = new WCFService();
            IEnumerable<GroupChatDTO> groupChats = service.GetGroupChat(token);

            if (groupChats != null)
            {
                foreach (GroupChatDTO chat in groupChats)
                {
                    ChatLookUC groupChatUC = new ChatLookUC();
                    GroupChatVM groupChatVM = new GroupChatVM();
                    groupChatVM.Chat.Id = chat.Id;
                    groupChatVM.Chat.Img = chat.Img;
                    groupChatVM.Chat.Name = chat.Name;
                    groupChatVM.Chat.Status = chat.Status + " users";
                    groupChatVM.Chat.ChatAdminId = chat.ChatAdminId;
                    groupChatUC.DataContext = groupChatVM;

                    groupChatUCs.Add(groupChatUC);

                }
            }

            return groupChatUCs;
        }

        public IEnumerable<MessageUC> GetMessages(ChatModel chatModel)
        {
            List<MessageUC> messageUCs = new List<MessageUC>();
            IService service = new WCFService();
            IChatMap chatMap = new Map();
            IEnumerable<MessageDTO> messageDTOs = service.GetMessages(chatMap.ChatModelToChatDTO(chatModel));

            if (messageDTOs != null)
            {
                foreach (MessageDTO mess in messageDTOs)
                {
                    MessageUC messageUC = new MessageUC();
                    MessageVM messageVM = new MessageVM();
                    messageVM.Message.Id = mess.Id;
                    messageVM.Message.Text = mess.Text;
                    messageVM.Message.Time = mess.Time;
                    messageVM.Message.Author = mess.Author;
                    messageVM.Message.Img = mess.Img;

                    messageUC.DataContext = messageVM;
                    messageUCs.Add(messageUC);

                }
            }

            return messageUCs;
        }

        public ChatModel GetOrCreateChat(AccountModel user, string token)
        {
            IUserMap userMap = new Map();
            IChatMap chatMap = new Map();
            IService service = new WCFService();
            return chatMap.ChatDTOToChatModel(service.GetOrCreateChat(userMap.AccountModelToAccountDTO(user), token));
            
        }

      

        public IEnumerable<ChatLookUC> GetSoloChatUC(string token)
        {
            List<ChatLookUC> soloChatUCs = new List<ChatLookUC>();
            IService service = new WCFService();
            IEnumerable<ChatDTO> chatDTOs = service.GetChats(token);

            if (chatDTOs != null)
            {
                foreach (ChatDTO chat in chatDTOs)
                {
                    ChatLookUC soloChatUC = new ChatLookUC();
                    SoloChatVM soloChatVM = new SoloChatVM();

                    soloChatVM.Chat.Id = chat.Id;
                    soloChatVM.Chat.Img = chat.Img;
                    soloChatVM.Chat.Name = chat.Name;
                    soloChatVM.Chat.Status = chat.Status;

                    soloChatUC.DataContext = soloChatVM;



                    soloChatUCs.Add(soloChatUC);

                }
            }

            return soloChatUCs;
        }

        public void SendMessage(ChatModel chatModel, string mess)
        {
            IService service = new WCFService();
            IChatMap chatMap = new Map();
            if (!service.SendMessage(chatMap.ChatModelToChatDTO(chatModel), MyUser.User.UserToken, mess))
            {
                MessageBox.Show("Error");
            }

        }
    }
}
