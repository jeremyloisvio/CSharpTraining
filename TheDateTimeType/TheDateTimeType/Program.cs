using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDateTimeType
{
    class Program
    {
        static void Main(string[] args)
        {

            //User Input BirthDate
            int month, day, year;
            Console.WriteLine("Enter Month: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Day: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());


            DateTime Birthday = new DateTime(year, month, day);
            double ageformula = DateTime.Today.Year - Birthday.Year;
            Console.WriteLine("Your Age is: " + ageformula + " ");
            TimeSpan days = DateTime.Today - Birthday;
            Console.WriteLine("You are: " + days.TotalDays + " Days Old");
            double today = days.TotalDays;
            double daysToNextAnniversary = 10000 - (today % 10000);
            Console.WriteLine("Remaining days until you turn 27 years old/10000 days are: " + daysToNextAnniversary.ToString());
            Console.ReadLine();

            //Static BirthDate
            //DateTime Birthday = new DateTime(1999,6,5);
            //double ageformula = DateTime.Today.Year-Birthday.Year;
            //Console.WriteLine("Your Age is: " +ageformula +" ");
            //TimeSpan days = DateTime.Today - Birthday;
            //Console.WriteLine("You are: " + days.TotalDays + " Days Old");
            //double today = days.TotalDays;
            //double daysToNextAnniversary = 10000 - (today % 10000);
            //Console.WriteLine("Remaining days until you turn 27 years old/10000 days are: " + daysToNextAnniversary.ToString());
            //Console.ReadLine();
            }
    }
}
