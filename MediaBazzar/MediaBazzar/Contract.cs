using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class Contract
    {

        private DateTime employmentStart;
        private DateTime employmentEnd;
        private string terminationReason;

        public Contract(DateTime employmentStart)
        {
            this.employmentStart = employmentStart;
            this.employmentEnd = new DateTime();
            terminationReason = string.Empty;
        }

        public void Terminate(DateTime date, string reason)
        {
            this.employmentEnd = date;
            this.terminationReason = reason;
        }

        public bool isTerminated()
        {
            if (employmentEnd == default(DateTime))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            if (!isTerminated())
            {
                return $"Contract beginning: {employmentStart}";
            }
            else
            {
                return $"Contract beginning: {employmentStart.ToShortDateString()}, Contract terminated: {employmentEnd.ToShortDateString()}, reason: {terminationReason}";
            }
        }
    }
}
