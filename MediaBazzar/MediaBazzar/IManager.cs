using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    interface IManager
    {
        bool Add(object obj);
        bool Remove(object obj);

        List<object> GetAllPerType(Type type);
    }
}
