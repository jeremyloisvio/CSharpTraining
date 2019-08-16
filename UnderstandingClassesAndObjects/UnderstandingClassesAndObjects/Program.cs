using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingClassesAndObjects
{


         public class Address
            {
                public string StreetAddress { get; set; }
                public string City { get; set; }
                public string State { get; set; }
                public string PostalCode { get; set; }
                public string Country { get; set; }
            }
            public class Person
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public Address ShippingAddress { get; set; }
            }


    class Program
    {
     
        static void Name()
        {
            List<string> NameList = new List<string>() { };
            Person names = new Person();
            Console.WriteLine("FirstName: ");
            names.FirstName = Console.ReadLine()+" ";
            Console.WriteLine("LastName: ");
            names.LastName = Console.ReadLine();
            NameList.Insert(0, names.FirstName);
            NameList.Insert(1, names.LastName);
            Console.WriteLine(String.Join("", NameList));
        }
        static void Address()
        {
            List<string> AddressList = new List<string>() { };
            Person addresses = new Person();
            addresses.ShippingAddress = new Address{ StreetAddress = "123 Main Street", City = "Sometown", State = "OH", PostalCode = "12345", Country = "United States" };
            AddressList.Add(addresses.ShippingAddress.StreetAddress);
            AddressList.Add(addresses.ShippingAddress.City);
            AddressList.Add(addresses.ShippingAddress.State);
            AddressList.Add(addresses.ShippingAddress.PostalCode);
            AddressList.Add(addresses.ShippingAddress.Country);
            foreach (var add in AddressList)
            {

                if (add == "123 Main Street" || add == "12345")
                {
                    Console.WriteLine(add);
                }
                else if (add == "United States")
                {
                    Console.WriteLine(add+"\n");
                }
                else
                {
                    Console.Write(add+", ");
                }
                
            }
            //Console.WriteLine(String.Join(",\n",PersonRecord));
        }


        static void Main(string[] args)
        {
            int count = 3;
            for (int i = 0; i < count; i++)
            {
                Name();
                Address();
            }
            Console.ReadLine();
        }
    }
         
}












                    
