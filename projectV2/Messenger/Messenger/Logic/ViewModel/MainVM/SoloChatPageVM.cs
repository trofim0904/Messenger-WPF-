﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Messenger.Presentation.View.Main.UserControls;
using System.Collections.ObjectModel;
using Messenger.Logic.ProcessingLogic.ChatLogic;
using Messenger.Mapping;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class SoloChatPageVM : BaseVM, INotifyPropertyChanged
    {
        private ObservableCollection<ChatLookUC> _chats;
        public ObservableCollection<ChatLookUC> Chats
        {
            get => _chats;
            set
            {
                _chats = value;
                OnPropertyChanged("Chats");
            }
        }
        private ISoloChat _soloChat;
        public SoloChatPageVM()
        {
            Map map = new Map();
            _soloChat = new ChatLogic();
            Chats = new ObservableCollection<ChatLookUC>(_soloChat.GetSoloChatUC(MyUser.User.UserToken));
            //Chats.Add(new ChatOrUserLookUC());
        }

      
    }
}
