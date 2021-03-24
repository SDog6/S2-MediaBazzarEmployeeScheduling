using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class FailedDatabaseInjectionException : Exception
    {
        public FailedDatabaseInjectionException(string type) : base($"Insertion of {type} in database failed!")
        {

        }
    }
}
