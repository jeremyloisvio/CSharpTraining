using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {

        var customer1 = new Customer() { Name = "Steve"};
        customer1.Orders.Add(new Order("123"));
        customer1.Orders.Add(new Order("234"));
        customer1.Orders.Add(new Order("345"));

        var customer2= new Customer() { Name = "Eric"};
        customer2.Orders.Add(new Order("100"));
        customer2.Orders.Add(new Order("200"));
        customer2.Orders.Add(new Order("300"));

        var customers = new List<Customer>() { customer1, customer2};

        // print customers
        var orders = new List<Order>();
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine("Orders:");
            orders = customer.Orders;
            while (orders.Count > 0)
            {
                Console.WriteLine(orders[0].OrderNumber);
                orders.RemoveAt(0); // don't write code like this
            }
        }
        Console.WriteLine("Customer 1 Order Count: " + customer1.Orders.Count);
        Console.WriteLine("Customer 2 Order Count: " + customer2.Orders.Count);

        Console.Read();
        }
    }




                public class Customer
            {
                public string Name { get; set; }
                public List<Order> Orders = new List<Order>();
            }

            public class Order 
            {
                public Order(string orderNumber)
                {
                    OrderNumber = orderNumber;
                }
                public string OrderNumber {get; set;}
            }
}
