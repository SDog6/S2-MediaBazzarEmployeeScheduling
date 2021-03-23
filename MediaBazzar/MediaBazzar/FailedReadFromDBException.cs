using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class FailedReadFromDBException : Exception
    {
        public FailedReadFromDBException() : base("Reading from database failed!")
        {

        }
            

    }
}
