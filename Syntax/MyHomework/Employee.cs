using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee : Person
    {
        public DateTime dateOfEmployment;
        public double salary;
        public int availableDaysOff;//nr de zile libere
        List<Leave> leave = new List<Leave>();

        public Employee(string lastName, string firstName, DateTime dateOfBirth, DateTime dateOfEmployment, double salary, int availableDaysOff)
            : base(lastName, firstName, dateOfBirth)
        {

            this.salary = salary;
            this.dateOfEmployment = dateOfEmployment;
            this.availableDaysOff = availableDaysOff;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(lastName);
            Console.WriteLine(firstName);
            Console.WriteLine(String.Format("{0:MM/dd/yyyy}", dateOfBirth));
            Console.WriteLine(String.Format("{0:MM/dd/yyyy}", dateOfEmployment));
            Console.WriteLine(salary);
            Console.WriteLine(availableDaysOff);
        }
        private void SubstractDays(int x)
        {
            availableDaysOff -= x;
        }

        public void AddnewLeave(Leave x)
        {
            if (availableDaysOff - x.duration < 0)
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului!");
           //verific sa nu fie in aceeasi perioada mai multe concedii pentru acelasi angajat
            foreach (Leave a in leave)
            {
                if (a.startingDate.AddDays(a.duration) >= x.startingDate && x.startingDate>=a.startingDate)
                {
                    throw new PeriodLeaveDays("Pe aceeasi perioada exista mai multe concedii!");
                }
                if (a.startingDate>= x.startingDate.AddDays(x.duration) )
                {
                    throw new PeriodLeaveDays("Pe aceeasi perioada exista mai multe concedii!");
                }
            }
            SubstractDays(x.duration);
            x.SetEmploye(this);
            leave.Add(x);
            foreach (Leave a in leave)
            {
                Console.WriteLine(a.duration);
    
            }

        }
        public void Vacation(  int year)
        {
            foreach (Leave a in leave)
            {
                if (a.startingDate.Year == year)
                {
                    Console.WriteLine(a.startingDate + "  " + a.startingDate.AddDays(a.duration));
                }   
            }
        }

    }
}
