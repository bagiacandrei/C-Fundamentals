using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHomework
{
    class LeaveDaysType : Exception
    {
        private string p;
        public LeaveDaysType()
            
        {

            //this.p = p;
        }
        public LeaveDaysType(string p)
        {
            
            this.p = p;
        }
    }
}
