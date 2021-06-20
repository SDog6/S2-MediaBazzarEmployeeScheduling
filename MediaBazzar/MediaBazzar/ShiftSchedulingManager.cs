using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    class ShiftSchedulingManager
    {

        private List<Shift> Shifts;

        private ShiftSchedulingData data;

        public ShiftSchedulingData ShiftData { get { return this.data; } set { data = value; } }

        public ShiftSchedulingManager()
        {
            ShiftData = new ShiftSchedulingData();
            loadDataFromDatabase();
        }


        private void loadDataFromDatabase()
        {
            Shifts = new List<Shift>();

            foreach (Shift o in (List<Shift>)ShiftData.ReadAll())
            {
                Shifts.Add((Shift)o);
            }
        }
        public bool Add(object obj)
        {
           
            if (obj != null)
            {
                ShiftData.Add((Shift)obj);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }


        }

        public List<object> GetAllPerType()
        {
            loadDataFromDatabase();
            List<object> temp = new List<object>();

            foreach (Shift item in Shifts)
            {
                temp.Add(item);
            }
            return temp;
        }

        public List<object> GetAllMorningShifts()
        {
            List<object> temp = new List<object>();

            foreach (Shift item in (List<Shift>)ShiftData.GetAllMorningShifts())
            {
                temp.Add(item);
            }
            return temp;
        }


        public List<object> GetAllAfternoonShifts()
        {
            List<object> temp = new List<object>();

            foreach (Shift item in (List<Shift>)ShiftData.GetAllAfternoonShifts())
            {
                temp.Add(item);
            }
            return temp;
        }


        public List<object> GetAllEveningShifts()
        {
            List<object> temp = new List<object>();

            foreach (Shift item in (List<Shift>)ShiftData.GetAllEveningShifts())
            {
                temp.Add(item);
            }
            return temp;
        }


        public void Remove(Shift s)
        {
            ShiftData.Delete(s.ID);
        }
    }
}
