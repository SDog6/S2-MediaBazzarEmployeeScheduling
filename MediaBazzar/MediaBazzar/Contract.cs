using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
   public class Contract
    {

        private DateTime employmentStart;
        private DateTime employmentEnd;
        private string terminationReason;
        public int maxworkhours;

        public DateTime EmploymentStart { get { return this.employmentStart; } }
        public DateTime EmploymentEnd { get { return this.employmentEnd; } }
        public string TerminationReason { get { return this.terminationReason; } }
        public Contract(DateTime employmentStart)
        {
            this.employmentStart = employmentStart;
            this.employmentEnd = new DateTime();
            terminationReason = string.Empty;
            maxworkhours = 20;
        }

        public Contract(DateTime employmentStart, DateTime employmentEnd, string terminationReason)
        {
            this.employmentStart = employmentStart;
            this.employmentEnd = employmentEnd;
            this.terminationReason = terminationReason;
            maxworkhours = 20;
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
