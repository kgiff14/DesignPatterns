using System;

namespace NullObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCustomer customer1 = CustomerFactory.GetCustomer("rob");
            AbstractCustomer customer2 = CustomerFactory.GetCustomer("joe");
            AbstractCustomer customer3 = CustomerFactory.GetCustomer("julie");
            AbstractCustomer customer4 = CustomerFactory.GetCustomer("bill");

            Console.WriteLine("Customers");
            Console.WriteLine(customer1.GetName());
            Console.WriteLine(customer2.GetName());
            Console.WriteLine(customer3.GetName());
            Console.WriteLine(customer4.GetName());
        }
    }
}
