using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughMembersOfACollection
{
    class Program
    {
        static void Main(string[] args)
        {



            Numbers();
                Console.Read();


           

        }


        static void Numbers()
        {
            var numberList = new List<int>() { };
            Number nums = new Number();
            Console.WriteLine("First Number: ");
            nums.numBer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            nums.numBer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third Number: ");
            nums.numBer3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            numberList.Insert(0, nums.numBer1);
            numberList.Insert(1, nums.numBer2);
            numberList.Insert(2, nums.numBer3);
            Console.WriteLine(String.Join(" ",numberList));
            Console.WriteLine("Sum " + numberList.Sum());

     


        }
    }



    public class Number
    {
        public int numBer1 { get; set; }
        public int numBer2 { get; set; }
        public int numBer3 { get; set; }



    }
}
