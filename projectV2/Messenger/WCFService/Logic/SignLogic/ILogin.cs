using MessangerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.Logic.SignLogic
{
    public interface ILogin
    {
        AccountDTO GetLogin(LoginDTO loginDTO, DeviceDTO deviceDTO);
    }
}
