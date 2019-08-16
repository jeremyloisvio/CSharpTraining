using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingBasedOnExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1)
            {
                int candidateFactor = 2;
                while (candidateFactor <= number)
                {
                    if (number % candidateFactor == 0)
                    {
                        Console.Write(candidateFactor);
                        int div = number / candidateFactor;
                        number = div;
                        if (number > 1)
                        {
                            Console.WriteLine(",");
                        }
                    }
                    candidateFactor++;
                }
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
