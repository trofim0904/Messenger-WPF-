using System.Collections.ObjectModel;
using Messenger.Presentation.View.Main.UserControls;
using Messenger.Logic.ProcessingLogic.DeviceLogic;

namespace Messenger.Logic.ViewModel.MainVM
{
    public class DeviceVM : BaseVM
    {
        private ObservableCollection<DeviceUC> _devices;
        
        /// <summary>
        /// Collection of user controls
        /// </summary>
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
        /// <summary>
        /// ctor
        /// </summary>
        public DeviceVM()
        {
            _deviceLogic = new DeviceLogic();
            Devices = new ObservableCollection<DeviceUC>(_deviceLogic.GetDeviceUC());      
        }

     
    }
}
