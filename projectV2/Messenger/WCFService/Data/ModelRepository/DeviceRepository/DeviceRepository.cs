using System.Collections.Generic;
using System.Linq;
using WCFService.Data.DataModels;

namespace WCFService.Data.ModelRepository.DeviceRepository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
       

        public void AddDeviceToUser(Device dev, int userId)
        {
            Create(dev);
            context.UserDevices.Add(new UserDevice() { DeviceId = dev.DeviceId, UserId = userId });
        }

        public IEnumerable<Device> GetUserDevices(int id)
        {
            return (from d in context.Devices
                    join c in context.UserDevices on d.DeviceId equals c.DeviceId
                    join u in context.Users on c.UserId equals u.UserId
                    where u.UserId == id
                    orderby d.DeviceId descending
                    select d).ToList();
        }

        public override void Update(Device item)
        {
            Device device = context.Devices.Find(item.DeviceId);
            device = item;
            
        }
    }
}
