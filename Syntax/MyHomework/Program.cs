using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
 
    class Program
    {   
         
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(1980, 1, 18);
            DateTime employment = new DateTime(2014,9, 25);
            DateTime starting = new DateTime(2015,10, 11);
            
            var empl = new Employee("Popecu", "Ion", birth,employment, 300, 20);
            var empl1 = new Employee("Popecu", "Ion", birth, employment, 300, 20);
            empl.DisplayInfo();

            var plecare = new Leave(starting, 5, "Medical");
            empl.AddnewLeave(plecare);
            
            empl.DisplayInfo();
            empl.Vacation(2015);

            
        } 
    }
}
