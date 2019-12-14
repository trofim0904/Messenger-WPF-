using Messenger.Presentation.View.Main.UserControls;
using System.Collections.Generic;

namespace Messenger.Logic.ProcessingLogic.DeviceLogic
{
    public interface IDeviceLogic
    {
        IEnumerable<DeviceUC> GetDeviceUC();
    }
}
