using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class EmptyTextBoxException : Exception
    {
        public EmptyTextBoxException() : base("You must input information in all required fields!")
        {

        }
    }
}
