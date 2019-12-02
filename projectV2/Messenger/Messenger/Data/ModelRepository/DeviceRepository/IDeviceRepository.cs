using Messenger.Data.DataModels;
using Messenger.Presentation.View.Main.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data.ModelRepository.DeviceRepository
{
    public interface IDeviceRepository : IRepository<Device>
    {
        IEnumerable<Device> GetUserDevices(int id);
    }
}
