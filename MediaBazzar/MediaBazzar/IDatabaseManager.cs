using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    interface IDatabaseManager
    {
        Object ReadAll();
        void Insert(object obj);
        void Delete(int id);
    }
}
