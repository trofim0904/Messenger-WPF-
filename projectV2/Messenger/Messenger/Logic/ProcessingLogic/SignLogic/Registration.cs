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
