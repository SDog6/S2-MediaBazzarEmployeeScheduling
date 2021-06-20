using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Contract
    {
        private int currentWorkingHours;
        private int workingHours;
        private DateTime employmentStart;
        private DateTime employmentEnd;
        private string terminationReason;
        private int id;
        private EmployeeData data = new EmployeeData();

        public int Workinghours { get { return this.workingHours; } }

        public int ID { get { return this.id; } }
        public int CurWorkinghours { get { return this.currentWorkingHours; } }
        public DateTime EmploymentStart { get { return this.employmentStart; } }
        public DateTime EmploymentEnd { get { return this.employmentEnd; } }
        public string TerminationReason { get { return this.terminationReason; } }
        public Contract(int id,int workingHours, DateTime employmentStart,int currentWorkingHours)
        {
            this.id = id;
            this.workingHours = workingHours;
            this.employmentStart = employmentStart;
            this.employmentEnd = new DateTime();
            terminationReason = string.Empty;
            this.currentWorkingHours = currentWorkingHours;
        }

        public Contract( int workingHours, DateTime employmentStart)
        {
            this.workingHours = workingHours;
            this.employmentStart = employmentStart;
            this.employmentEnd = new DateTime();
            terminationReason = string.Empty;
      
        }

        public Contract(int workingHours, DateTime employmentStart, DateTime employmentEnd, string terminationReason)
        {
            this.workingHours = workingHours;
            this.employmentStart = employmentStart;
            this.employmentEnd = employmentEnd;
            this.terminationReason = terminationReason;
        }

        public bool ShiftPossible()
        {
            if(CurWorkinghours + 5 <= workingHours)
            {
                return true;
            }
            return false;
        }

        public void AddShift()
        {
            data.IncraseWork(this.id);
            currentWorkingHours += 5;
        }


        public void RemoveShift()
        {
            data.DecreaseWorkHours(this.id);
        }
        public void Terminate(string reason)
        {
            this.employmentEnd = DateTime.Now;
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
