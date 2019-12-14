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
    public interface IMainMap
    {
        DeviceDTO DeviceToDeviceDTO(Device device);

        Device DeviceDTOToDevice(DeviceDTO deviceDTO);

        ChangeModel ChangeDTOToChangeModel(ChangeDTO changeDTO);

        User ChangeModelToUser(ChangeModel changeModel);

        User AccountModelToUser(AccountModel accountModel);

        ChatDTO ChatToChatDTO(Chat chat);

        Chat ChatDTOToChat(ChatDTO chatDTO);

        GroupChatDTO ChatToGroupChatDTO(Chat chat);

        MessageDTO MessageToMessageDTO(Message message);
    }
}
