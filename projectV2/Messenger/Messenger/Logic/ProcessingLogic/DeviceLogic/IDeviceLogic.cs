using Messenger.Data.DataModels;
using Messenger.Presentation.View.Main.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Logic.ProcessingLogic.DeviceLogic
{
    public interface IDeviceLogic
    {
        IEnumerable<DeviceUC> GetDeviceUCByUserId(int id);
    }
}
