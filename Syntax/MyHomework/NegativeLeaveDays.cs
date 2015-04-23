using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHomework
{
    class NegativeLeaveDays : Exception
    {
        private string p;
        public NegativeLeaveDays()
            
        {

            //this.p = p;
        }
        public NegativeLeaveDays(string p)
        {
            
            this.p = p;
        }
    }
}
