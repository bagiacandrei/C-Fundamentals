using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {
        public DateTime startingDate;
        public int duration;
        public string leaveType; //(medical, holiday, other)
        public Employee emp;
        public enum LeaveTypeEnum
        {
            Medical,
            Holiday,
            Other
        }


        public Leave(DateTime StartingDate, int Duration, string LeaveType)
        {
            this.startingDate = StartingDate;
            this.duration = Duration;
            bool ok = false;
            //verific sa nu fie concedii ce acelasi tip 
            foreach(var value in Enum.GetValues(typeof(LeaveTypeEnum)))
            {
                if (value.ToString()== LeaveType)
                    ok = true;
            }
            if (ok == true)
                this.leaveType = LeaveType;
            else
                throw new LeaveDaysType("Pe aceeasi perioada exista mai multe tipuri de concedii");
        }

        internal void SetEmploye(Employee employee)
        {
            this.emp = employee;
        }

    }
}
