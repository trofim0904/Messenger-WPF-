using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Logic.MainLogic
{
    public interface IMessageLogic
    {
        IEnumerable<MessageDTO> GetMessages(ChatDTO chatDTO);

        bool SendMessage(ChatDTO chatDTO, string token, string message);
    }
}
