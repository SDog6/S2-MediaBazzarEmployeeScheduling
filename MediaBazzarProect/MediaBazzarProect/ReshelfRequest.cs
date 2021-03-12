using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzarProect
{
    class ReshelfRequest
    {
        private Stock lowstock;
        private DateTime filedDate;

        public ReshelfRequest(Stock lowstock, DateTime filedDate)
        {
            this.lowstock = lowstock;
            this.filedDate = filedDate;
        }

        public override string ToString()
        {
            return $"{lowstock}";
        }
    }

}
