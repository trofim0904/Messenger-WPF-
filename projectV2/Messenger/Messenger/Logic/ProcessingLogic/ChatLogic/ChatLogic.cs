using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Messenger.Data.DataModels;
using Messenger.Data.ModelRepository.ChatRepository;
using Messenger.Data.ModelRepository.UserRepository;
using Messenger.Logic.Models;
using Messenger.Logic.ViewModel.MainVM;
using Messenger.Presentation.View.Main.UserControls;

namespace Messenger.Logic.ProcessingLogic.ChatLogic
{
    public class ChatLogic : ISoloChat, IGroupChat, IChattingLogic
    {
        public IEnumerable<ChatLookUC> GetGroupChatUC(User user)
        {
            List<ChatLookUC> groupChatUCs = new List<ChatLookUC>();
            IEnumerable<Chat> groupChats;

            using (ChatRepository repository = new ChatRepository())
            {
                groupChats = repository.GetGroupChats(user);
            }
            if (groupChats != null)
            {
                foreach (Chat chat in groupChats)
                {
                    ChatLookUC groupChatUC = new ChatLookUC();
                    GroupChatVM groupChatVM = new GroupChatVM();

                    groupChatVM.Chat.Id = chat.ChatId;
                    groupChatVM.Chat.Img = chat.ChatImg;
                    groupChatVM.Chat.Name = chat.ChatName;
                    groupChatVM.Chat.Status = chat.ChatStatus + " users";
                    groupChatVM.Chat.ChatAdminId = chat.ChatAdminId;

                    groupChatUC.DataContext = groupChatVM;

                    //soloChatUC._imgMain.Source = new BitmapImage(new Uri(chat.ChatImg, UriKind.Absolute));
                    //soloChatUC._nameTb.Text = chat.ChatName;
                    //soloChatUC._statusTb.Text = chat.ChatStatus;

                    groupChatUCs.Add(groupChatUC);

                }
            }

            return groupChatUCs;
        }

        public IEnumerable<MessageUC> GetMessages(ChatModel chatModel)
        {
            List<MessageUC> messageUCs = new List<MessageUC>();
            IEnumerable<Message> messages;

            using (ChatRepository repository = new ChatRepository())
            {
                messages = repository.GetMessages(chatModel);
            }
            if (messages != null)
            {
                foreach (Message mess in messages)
                {
                    MessageUC messageUC = new MessageUC();
                    MessageVM messageVM = new MessageVM();

                    messageVM.Message.Id = mess.MesId;
                    messageVM.Message.Text = mess.MesText;
                    messageVM.Message.Time = mess.MesTime;
                    using (UserRepository repository = new UserRepository())
                    {
                        User user = repository.GetItem(mess.MesUserId);
                        messageVM.Message.Author = user.UserLogin;
                        messageVM.Message.Img = user.UserImg;
                    }
                    messageUC.DataContext = messageVM;
                    messageUCs.Add(messageUC);

                }
            }

            return messageUCs;
        }

        public ChatModel GetOrCreateChat(AccountModel user)
        {
            ChatModel chatModel = new ChatModel();
            Chat chat = new Chat();
            using(ChatRepository repository = new ChatRepository())
            {
                chat = repository.FindSoloChatByUser(user);
                chatModel.Id = chat.ChatId;
                chatModel.Img = chat.ChatImg;
                chatModel.Name = chat.ChatName;
                chatModel.Status = chat.ChatStatus;

                repository.Save();
            }
            
            return chatModel;
        }

        public IEnumerable<ChatLookUC> GetSoloChatUC(User user)
        {
            List<ChatLookUC> soloChatUCs = new List<ChatLookUC>();
            IEnumerable<Chat> soloChats;

            using (ChatRepository repository = new ChatRepository())
            {
                soloChats = repository.GetSoloChats(user);
            }
            if (soloChats != null)
            {
                foreach (Chat chat in soloChats)
                {
                    ChatLookUC soloChatUC = new ChatLookUC();
                    SoloChatVM soloChatVM = new SoloChatVM();

                    soloChatVM.Chat.Id = chat.ChatId;
                    soloChatVM.Chat.Img = chat.ChatImg;
                    soloChatVM.Chat.Name = chat.ChatName;
                    soloChatVM.Chat.Status = chat.ChatStatus;

                    soloChatUC.DataContext = soloChatVM;

                    

                    soloChatUCs.Add(soloChatUC);

                }
            }

            return soloChatUCs;
        }

        public void SendMessage(ChatModel chatModel, string mess)
        {
            if (mess == null)
            {
                MessageBox.Show("Error");
                return;
            }
            using (ChatRepository repository = new ChatRepository())
            {
                repository.AddMessage(chatModel, mess);
                repository.Save();
            }

        }
    }
}
