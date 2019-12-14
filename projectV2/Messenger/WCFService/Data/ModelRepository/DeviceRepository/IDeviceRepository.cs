using System.Collections.Generic;
using WCFService.Data.DataModels;

namespace WCFService.Data.ModelRepository.DeviceRepository
{
    public interface IDeviceRepository : IRepository<Device>
    {
        IEnumerable<Device> GetUserDevices(int id);
    }
}
