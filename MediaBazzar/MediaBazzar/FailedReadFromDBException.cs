using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class FailedReadFromDBException : Exception
    {
        public FailedReadFromDBException(string type) : base($"Reading of {type} from database failed!")
        {

        }
            

    }
}
