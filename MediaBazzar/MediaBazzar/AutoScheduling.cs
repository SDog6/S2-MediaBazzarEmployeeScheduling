using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public class AutoScheduling
    {
        Dictionary<Employee, List<ShiftRequest>> requests;
        ShiftSchedulingManager shifts;
        ShiftLimitData limitsData;
        ShiftConverter converter;
      
        List<decimal> limits;
        List<int> counters;
        public AutoScheduling()
        {
            this.requests = new Dictionary<Employee, List<ShiftRequest>>();
            this.shifts = new ShiftSchedulingManager();
            this.limitsData = new ShiftLimitData();
            this.converter = new ShiftConverter();
            this.limits = limitsData.GetLimits();
            this.counters = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public bool InsertRequests(List<ShiftRequest> shiftrequests)
        {
            if(shiftrequests.Count < 1)
            {
                return false;
            }
            Clear();
            SortRequests(shiftrequests);
            return true;
        }

        private void SortRequests(List<ShiftRequest> shiftRequests)
        {
            foreach(ShiftRequest item in shiftRequests)
            {
                Employee emp = item.Emp;
                if (!requests.ContainsKey(emp))
                {
                    requests[emp] = new List<ShiftRequest>();
                }               
                requests[emp].Add(item);
            }
            requests.OrderBy(key => key.Value.Count);
        }

        public List<ShiftRequest> Schedule()
        {
            List<ShiftRequest> remaining = new List<ShiftRequest>();
            foreach(KeyValuePair<Employee, List<ShiftRequest>> pair in requests)
            {
                List<ShiftRequest> temp = ScheduleEmployee(pair);
                if(temp != null)
                {
                    remaining.Concat(temp).ToList();
                }
            }
            if(remaining.Count > 0)
            {
                remaining = ScheduleRemaining(remaining);
                if (remaining != null)
                {
                    return remaining;
                }
            }
            return null;
        }

        private List<ShiftRequest> ScheduleEmployee(KeyValuePair<Employee, List<ShiftRequest>> pair)
        {
            List<ShiftRequest> RemainingShifts = new List<ShiftRequest>();
            for (int i = 0; i < pair.Value.Count; i++)
            {
                int shift = ((((int)pair.Value[i].GetDayOfWeek() + 6) % 7) * 3) + pair.Value[i].GetShiftType() - 1;
                if ((int)limits[shift] >= counters[shift] + 1)
                {
                   
                        if (pair.Key.Contract.ShiftPossible())
                        {
                            Shift s = converter.RequestToShift(pair.Value[i]);
                            pair.Key.Contract.AddShift();
                            shifts.Add(s);

                        }
                        else
                        {
                            RemainingShifts.Add(pair.Value[i]);
                        }
               
                  
                }
            }
            if (!pair.Key.Contract.ShiftPossible())
            {
                return null;
            }
            else
            {
                return RemainingShifts;
            }
        }

        private List<ShiftRequest> ScheduleRemaining(List<ShiftRequest> remaining)
        {
            for(int i = 0; i < 21; i++)
            {
                if(counters[i] + 1 > (int)limits[i])
                {
                    if(remaining.Count < 1)
                    {
                        return null;
                    }
                    Shift s = converter.RequestToShift(remaining[0]);
                    shifts.Add(s);
                    remaining.RemoveAt(0);
                }
            }
            return remaining;
        }

        private void Clear()
        {
            shifts.ClearNextWeek();
            requests.Clear();
            for(int i = 0; i < 21; i++)
            {
                counters[i] = 0;
            }
        }
        private Shift RequestToShift(ShiftRequest request)
        {

            return null;
        }
    }
}
