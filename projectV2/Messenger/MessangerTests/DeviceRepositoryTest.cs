using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerLogic.Data.DataModels;
using ServerLogic.Data.ModelRepository.DeviceRepository;

namespace MessangerTests
{
    [TestClass]
    public class DeviceRepositoryTest
    {
        Device device = new Device();
        public DeviceRepositoryTest()
        {
            device.DeviceId = 6;
            device.DeviceIp = "192.168.0.3";
            device.DeviceName = "DESKTOP-DL9PHFJ";
            device.DeviceTime = "15:22:42";
        }
        [TestMethod]
        public void CheckGetItem()
        {
            //arange
            Device real;
            //action
            using (DeviceRepository repository = new DeviceRepository())
            {
                real = repository.GetItem(device.DeviceId);
            }
            //assert
            Assert.AreEqual(device.DeviceId, real.DeviceId);
        }
        [TestMethod]
        public void CheckGetItemList_first()
        {
            //arange
            Device real;
            //action
            using (DeviceRepository repository = new DeviceRepository())
            {
                var list = repository.GetItemList();
                real = list.Where(d => d.DeviceId == device.DeviceId).First();
            }
            //assert
            Assert.AreEqual(device.DeviceId, real.DeviceId);
        }
    }
}