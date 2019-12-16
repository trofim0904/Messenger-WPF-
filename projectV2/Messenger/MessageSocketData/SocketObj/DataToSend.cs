using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.SocketObj
{
    [Serializable]
    public class DataToSend
    {
        
        public object FirstObject { get; set; }

        public object SecondObject { get; set; }

        public Action Action { get; set; }

        public string Token { get; set; }

        public string Params { get; set; }

        public bool Boolean { get; set; }
    }
}
