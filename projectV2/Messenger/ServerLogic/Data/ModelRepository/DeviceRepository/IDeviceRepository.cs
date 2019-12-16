using System.Collections.Generic;
using ServerLogic.Data.DataModels;

namespace ServerLogic.Data.ModelRepository.DeviceRepository
{
    public interface IDeviceRepository : IRepository<Device>
    {
        IEnumerable<Device> GetUserDevices(int id);
    }
}
