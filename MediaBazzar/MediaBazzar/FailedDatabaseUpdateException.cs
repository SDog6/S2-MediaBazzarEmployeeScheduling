﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class FailedDatabaseUpdateException : Exception
    {
        public FailedDatabaseUpdateException() : base("Database update failed!")
        {

        }
    }
}
