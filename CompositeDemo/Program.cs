using System;

namespace CompositeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee CEO = new Employee("Jim", "CEO", 200000);

            Employee headSales = new Employee("John", "Head Sales", 12000);

            Employee headMarketing = new Employee("Mary", "Head Marketing", 61000);

            Employee clerk1 = new Employee("Bob", "clerk", 1300);
            Employee clerk2 = new Employee("Jane", "clerk", 15400);

            Employee sales1 = new Employee("Anna", "sales", 6402);
            Employee sales2 = new Employee("Todd", "sales", 8740);

            CEO.Add(headSales);
            CEO.Add(headMarketing);

            headSales.Add(sales1);
            headSales.Add(sales2);

            headMarketing.Add(clerk2);
            headMarketing.Add(clerk1);

            Console.WriteLine(CEO.ToString());

            foreach(Employee headEmployee in CEO.GetSubordinates())
            {
                Console.WriteLine(headEmployee.ToString());

                foreach(Employee employee in headEmployee.GetSubordinates())
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }
    }
}
