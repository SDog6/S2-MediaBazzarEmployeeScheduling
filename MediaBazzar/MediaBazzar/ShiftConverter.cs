using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ShiftConverter
    {
        public ShiftConverter()
        {

        }

        public Shift RequestToShift(ShiftRequest request)
        {
            Employee emp = request.Emp;
            DateTime date = GetDay(request.GetDayOfWeek());
            string shiftType = request.ShiftType;         
            return new Shift(emp, date, shiftType);
        }

        private DateTime GetDay(DayOfWeek day)
        {
            DateTime start = DateTime.Now.AddDays(1);
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }
    }
}
