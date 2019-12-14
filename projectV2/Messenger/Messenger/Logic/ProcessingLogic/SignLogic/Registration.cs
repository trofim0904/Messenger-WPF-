using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Messenger.Data.DataModels;
using Messenger.Data.ModelRepository.UserRepository;
using Messenger.Logic.Models;
using Messenger.Mapping;
using Messenger.Services;

namespace Messenger.Logic.ProcessingLogic.SignLogic
{
    public class Registration : IRegistration
    {
        public bool GetRegistred(RegistrationModel model)
        {
            IService service = new WCFService();
            ISignMap map = new Map();
            return service.Registration(map.RegistrationModelToRegistrationDTO(model));
        }

        
    }
}
