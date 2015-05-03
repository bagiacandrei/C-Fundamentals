using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHomework
{
    class PeriodLeaveDays : Exception
    {
        private string p;
        public PeriodLeaveDays()
            
        {

            //this.p = p;
        }
        public PeriodLeaveDays(string p)
        {
            
            this.p = p;
        }
    }
}
