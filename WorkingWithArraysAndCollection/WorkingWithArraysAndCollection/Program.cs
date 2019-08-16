using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArraysAndCollection
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string> grocerylist = new List<string>() { };
        int count = 0;
        Console.WriteLine("Grocery List: " + (String.Join("\n", grocerylist)));

        while (true)
        {

            Console.WriteLine("Enter Command (+ (to add item), - (to remove item), or -- (to clear the list)");
            var answer = (Console.ReadLine());
            if (answer == "exit") break;
            if (answer == "+")
            {
                grocerylist.Insert(count, "some item");
                Console.WriteLine("Grocery List: \n" + String.Join("\n", grocerylist));
                count++;

            }
            else if (answer == "-" && count > 0)
            {
                grocerylist.RemoveAt(grocerylist.Count - 1);
                Console.WriteLine("Grocery List: \n" + String.Join("\n", grocerylist));              
                count--;
            }
            else if (answer == "--")
            {

                grocerylist.Clear();
                Console.WriteLine("Grocery List: ");
                count = 0;
            }
            else if(answer == "-" &&  count ==  0){
                Console.WriteLine("The List is Empty");
            }
            else
            {

                Console.WriteLine("Not on the choices!");
            }


        }
        Console.WriteLine("Done");
        Console.Read();
        }
    }
}
