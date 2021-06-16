using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class ShiftSchedulingRequestsManager
    {

        private List<ShiftRequest> Shifts;

        private ShiftSchedulingRequestsData data;

        public ShiftSchedulingRequestsData ShiftData { get { return this.data; } set { data = value; } }

        public ShiftSchedulingRequestsManager()
        {
            ShiftData = new ShiftSchedulingRequestsData();
            loadDataFromDatabase();
        }


        private void loadDataFromDatabase()
        {
            Shifts = new List<ShiftRequest>();

            foreach (ShiftRequest o in (List<ShiftRequest>)ShiftData.ReadAll())
            {
                Shifts.Add((ShiftRequest)o);
            }
        }

        public List<object> GetAll()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in Shifts)
            {
                temp.Add(item);
            }
            return temp;
        }

       
        public List<object> GetAllMorningShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllMorningShifts())
            {
                temp.Add(item);
            }
            return temp;
           
        }


        public List<object> GetAllAfternoonShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllAfternoonShifts())
            {
                temp.Add(item);
            }
            return temp;
        }


        public List<object> GetAllEveningShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllEveningShifts())
            {
                temp.Add(item);
            }
            return temp;
        }

        public List<object> GetAllRequestsByDay(string day)
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllRequestsByDay(day))
            {
                temp.Add(item);
            }
            return temp;
        }


        public bool Remove(object obj)
        {
            if (obj != null)
            {
                ShiftData.Delete((ShiftRequest)obj);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
