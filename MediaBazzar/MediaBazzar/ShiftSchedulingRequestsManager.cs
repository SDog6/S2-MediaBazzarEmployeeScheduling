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
        public List<object> GetAllMondayShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllMondayShifts())
            {
                temp.Add(item);
            }
            return temp;
        }

        public List<object> GetAllTuesdayShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllTuesdayShifts())
            {
                temp.Add(item);
            }
            return temp;
        }


        public List<object> GetAllWednesdayShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllWednesdayShifts())
            {
                temp.Add(item);
            }
            return temp;
        }


        public List<object> GetAllThursdayShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllThursdayShifts())
            {
                temp.Add(item);
            }
            return temp;
        }

        public List<object> GetAllFridayShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllFridayShifts())
            {
                temp.Add(item);
            }
            return temp;
        }

        public List<object> GetAllSaturdayShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllSaturdayShifts())
            {
                temp.Add(item);
            }
            return temp;
        }

        public List<object> GetAllSundayShifts()
        {
            List<object> temp = new List<object>();

            foreach (ShiftRequest item in (List<ShiftRequest>)ShiftData.GetAllSundayShifts())
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
