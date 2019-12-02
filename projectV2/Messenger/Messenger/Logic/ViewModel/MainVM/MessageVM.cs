using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Messenger.Logic.Models;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class MessageVM : BaseVM, INotifyPropertyChanged
    {
        private MessageModel _message;
        public MessageModel Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        }
        public MessageVM()
        {
            Message = new MessageModel();
        }


      
    }
}
