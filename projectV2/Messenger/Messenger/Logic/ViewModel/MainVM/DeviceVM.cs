using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Messenger.Presentation.View.Main.UserControls;
using Messenger.Logic.ProcessingLogic.DeviceLogic;
using System.Windows;
using Messenger.Data.DataModels;
using Messenger.Data;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class DeviceVM : BaseVM, INotifyPropertyChanged
    {
        private ObservableCollection<DeviceUC> _devices;
        
        public ObservableCollection<DeviceUC> Devices
        {
            get => _devices;
            set
            {
                _devices = value;
                OnPropertyChanged("Devices");
            }
        }
        private IDeviceLogic _deviceLogic;
        public DeviceVM()
        {
            _deviceLogic = new DeviceLogic();
            Devices = new ObservableCollection<DeviceUC>(_deviceLogic.GetDeviceUCByUserId(MyUser.User.UserId));
            
            
            //_deviceLogic = new DeviceLogic();
            //Devices = _deviceLogic.GetDeviceUCByUserId(MyUser.User.UserId) as ObservableCollection<DeviceUC>;
            //MessageBox.Show(_deviceLogic.GetDeviceUCByUserId(MyUser.User.UserId).First()._nameTb.Text);
            //using (MessangerContext context = new MessangerContext())
            //{
            //    var i = (from d in context.Devices
            //    join c in context.UserDevices on d.DeviceId equals c.DeviceId
            //    join u in context.Users on c.UserId equals u.UserId
            //    where u.UserId == 1
            //    select d).ToList();
            //    MessageBox.Show(i.ToString());
            //}
            //MessageBox.Show(i);

            // MessageBox.Show( _deviceLogic.GetDeviceUCByUserId(MyUser.User.UserId).ToString());




        }

     
    }
}
