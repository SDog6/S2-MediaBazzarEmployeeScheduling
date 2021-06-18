using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ShiftLimitManager
    {
        List<int> limits;
        ShiftLimitData data;

        public ShiftLimitManager()
        {
            this.limits = new List<int>();
            this.data = new ShiftLimitData();
        }

        public List<int> GetLimits()
        {
            limits = data.GetLimits();
            return limits;
        }


    }
}
