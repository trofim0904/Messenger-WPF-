using Messenger.Logic.Models;
using Messenger.MessangerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Mapping
{
    public interface IChatMap
    {
        ChatDTO ChatModelToChatDTO(ChatModel chatModel);

        ChatModel ChatDTOToChatModel(ChatDTO chatDTO);
    }
}
