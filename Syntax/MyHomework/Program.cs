using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Person
    {
        protected string lastname;
        protected string firstname;
        protected DateTime dateOfBirth;
    }
    class Employee : Person
    {
        public DateTime dateOfEmployment;
        public int salary;
        public int availableDaysOff;//nr de zile libere

        public Employee(string Lastname, string Firstname, DateTime DateOfBirth, DateTime DateOfEmployment, int Salary, int AvailableDaysOff)
        {
            this.lastname = Lastname;
            this.firstname = Firstname;
            this.dateOfBirth = DateOfBirth;
            this.dateOfEmployment = DateOfEmployment;
            this.salary = Salary;
            this.availableDaysOff = AvailableDaysOff;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(lastname);
            Console.WriteLine(firstname);
            Console.WriteLine(String.Format("{0:MM/dd/yyyy}", dateOfBirth));
            Console.WriteLine(String.Format("{0:MM/dd/yyyy}", dateOfEmployment));
            Console.WriteLine(salary);
            Console.WriteLine(availableDaysOff);
        }
        private void SubstractDays(int x)
        {
        availableDaysOff-=x;}

        public void AddnewLeave(Leave x)
        {
            if (availableDaysOff - x.getduration() < 0)
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
            SubstractDays(x.getduration());
            x.Setemploye(this);

            
        }
    }
   sealed class Leave
    {
        public DateTime startingDate;
        public int duration;
        public string leaveType; //(medical, holiday, other)
        public Employee emp ;

       
        public Leave(DateTime StartingDate,int Duration,string LeaveType)
        {
            this.startingDate = StartingDate;
            this.duration = Duration;
            this.leaveType = LeaveType;
            
        }
       internal int getduration()
        {
            return duration;
        }

        internal void Setemploye(Employee employee)
        {
            this.emp = employee;
        }
      
    }
   
    class Program
    {   
         
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(1980, 1, 18);
            DateTime employment = new DateTime(2014,9, 25);
            DateTime starting = new DateTime(2015,10, 11);
            
            Employee empl = new Employee("Popecu", "Ion", birth,employment, 300, 20);
            empl.DisplayInfo();
            Leave plecare = new Leave(starting, 15, "holiday");
            empl.AddnewLeave(plecare);
            empl.DisplayInfo();
        } 
    }
}
