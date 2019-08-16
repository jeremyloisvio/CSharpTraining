using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
        string name = "Vio";
        string greetTemplate = "Have a Good Day **NAME**!";
        string greet4 = greetTemplate.Replace("**NAME**", name);
        Console.WriteLine(greet4);
        Console.ReadLine();
        }
    }
}