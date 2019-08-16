using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int correctNumber = new Random().Next(3) + 1;
                Console.WriteLine("Guess a number between 1 to 3");
                int guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber == correctNumber)
                {
                    Console.WriteLine("Your guess is correct! " + " the Number is: " + correctNumber);
                    Console.ReadLine();
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("Your guess is higher than the Number " + " The number is " + correctNumber);
                    Console.ReadLine();
                }

                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("Your guess is lower than the Number " + " The number is " + correctNumber);
                    Console.ReadLine();
                }

                else if (guessedNumber>3)
                {
                    Console.WriteLine("Choose only between 1 to 3!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("your number is not accepted");
                    Console.ReadLine();

                }






            }
            catch (Exception ex)
            {
                Console.WriteLine("Integer only!");
                Console.ReadLine();
            }
        }
       
    }
}
