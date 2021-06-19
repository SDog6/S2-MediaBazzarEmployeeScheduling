using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ShiftLimitManager
    {
        List<decimal> limits;
        ShiftLimitData data;

        public ShiftLimitManager()
        {
            this.limits = data.GetLimits();
            this.data = new ShiftLimitData();
        }

        public List<decimal> GetLimits()
        {
            return limits;
        }

        public void UpdateLimits(List<decimal> newLimits)
        {
            this.limits = newLimits;
            data.SetLimits(newLimits);
        }
    }
}
