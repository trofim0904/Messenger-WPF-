using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSocketData.MappingDTOSocket
{
    public interface IMapping<FirstObj, SecondObj>
    {
        FirstObj MapTo(SecondObj obj);
        SecondObj MapFrom(FirstObj obj);
    }
}
