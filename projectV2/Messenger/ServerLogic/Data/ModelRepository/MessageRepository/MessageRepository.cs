using ServerLogic.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Data.ModelRepository.MessageRepository
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository 
    {
        public override void Update(Message item)
        {
            Message message = context.Messages.Find(item.MesId);
            message = item;
        }
    }
}
