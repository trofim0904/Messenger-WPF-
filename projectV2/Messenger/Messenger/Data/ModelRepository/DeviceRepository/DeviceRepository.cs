using Messenger.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data.ModelRepository.DeviceRepository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        //public override void Create(Device item)
        //{
        //    context.Devices.Add(item);
        //}

        //public override void Delete(int id)
        //{
        //    Device device = context.Devices.Find(id);
        //    if (device != null)
        //    {
        //        context.Devices.Remove(device);
        //    }
        //}

        //public override Device GetItem(int id)
        //{
        //    return context.Devices.Find(id);
        //}

        //public override IEnumerable<Device> GetItemList()
        //{
        //    return context.Devices;
        //}

        public void AddDeviceToUser(Device dev,User user)
        {
            Create(dev);
            context.UserDevices.Add(new UserDevice() { DeviceId = dev.DeviceId, UserId = user.UserId });
        }

        public IEnumerable<Device> GetUserDevices(int id)
        {
            return (from d in context.Devices
                   join c in context.UserDevices on d.DeviceId equals c.DeviceId
                   join u in context.Users on c.UserId equals u.UserId
                   where u.UserId == id
                   select d).ToList();
        }

        public override void Update(Device item)
        {
            Device device = context.Devices.Find(item.DeviceId);
            device = item;
            
        }
    }
}
