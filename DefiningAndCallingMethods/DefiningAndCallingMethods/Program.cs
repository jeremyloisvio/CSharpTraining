using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningAndCallingMethods
{
    class Program
    {
        static List<string> grocerylist = new List<string>() { };
        static int count=0;
        static void Main()
        {
            
                    DisplayHeader();
                    DisplayMenu();
                    
                    while (true)
                    {
                        Console.WriteLine("Enter Choice");
                        var answer = (Console.ReadLine());
                        if (answer == "exit") break;
                        if (answer == "+")
                        {
                            Condition1();
                        }
                        else if (answer == "-" && count > 0)
                        {
                            Condition2();
                        }
                        else if (answer == "--")
                        {
                            Condition3();
                        }
                        else if (answer == "-" && count == 0)
                        {
                            Condition4();
                        }
                        else
                        {
                            Condition5();
                        }


                    }

                    Console.WriteLine("Done!"); 
                    Console.Read();  
          


        }
        
            static void DisplayHeader()
            {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("****Grocery*******************");
                    Console.WriteLine("-----------------------------------------");
            }

            static void DisplayMenu()
            {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("+ = Add an Item");
            Console.WriteLine("- = Remove an Item");
            Console.WriteLine("-- = Clear the List");

            }

            static void Condition1()
            {
                grocerylist.Insert(count, "some item");
                Console.WriteLine("Grocery List: \n" + String.Join("\n", grocerylist));
                count++;

            }

            static void Condition2()
            {
                grocerylist.RemoveAt(grocerylist.Count - 1);
                Console.WriteLine("Grocery List: \n" + String.Join("\n", grocerylist));
                count--;
            }

            static void Condition3()
            {
                grocerylist.Clear();
                Console.WriteLine("Grocery List: ");
                count = 0;
            }

            static void Condition4()
            {
                Console.WriteLine("The List is Empty!");
            }


            static void Condition5()
            {
                Console.WriteLine("Not on the Choices!");
            }


    }
}
