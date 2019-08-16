using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhenAndHowToUseExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMissingTokenException();
            Console.WriteLine("\n");
            MyInvalidTokenException();
            Console.Read();

        }

        public static List<string> GetAccessPermissions(string token)
        {
            return new List<string> { token };
        }

        public static void MyMissingTokenException()
        {
            List<string> sad = GetAccessPermissions(null);

            foreach (var item in sad)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    try
                    {
                        throw new ArgumentException("Token shouldn't be null");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

        }
        public static void MyInvalidTokenException()
        {
            List<string> sad = GetAccessPermissions("vio");
            foreach (var item in sad)
            {
                if (item.Length < 5)
                {
                    try
                    {

                        throw new ArgumentException("The token's length should be 5 to 10 letters,  length is: " + item.Length);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine(item);
                }

            }


        }
    }
}
