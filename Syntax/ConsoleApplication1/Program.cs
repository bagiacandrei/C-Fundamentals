using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1=new MyClass();
            MyClass obj2 = new MyClass();
            MyClass obj3 = new MyClass();
            Console.WriteLine(MyClass.count);
 
        }
       
    }
    public class MyClass
    {
        public static int count;
        public MyClass()
        {
            count++;
        }

    }
}
