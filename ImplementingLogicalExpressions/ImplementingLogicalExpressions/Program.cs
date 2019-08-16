using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLogicalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

           //var time = new DateTime(2019, 4, 1, 20, 0, 0); for a specific time
            var time = DateTime.Now;
            var hour = time.Hour;
            int hr = Convert.ToInt32(hour);
            Console.WriteLine("The Time now is : "+time);
            if (hr >= 0 && hr < 12)
            {
                Console.WriteLine("Good Morning!");
            }
            if (hr >= 12 && hr < 18)
            {
                Console.WriteLine("Good Afternoon!");
            }
            if (hr >= 18 && hr < 23)
            {
                Console.WriteLine("Good Evening");
            }
            if(hr >= 23 && hr<0) 
            {
                Console.WriteLine("Goodnight");
            }
            Console.ReadLine();
        }
    }
}
