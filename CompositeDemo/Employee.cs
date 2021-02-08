using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDemo
{
    public class Employee
    {
        private string name { get; set; }
        private string dept { get; set; }
        private int salary { get; set; }
        private List<Employee> subordinates { get; set; }

        public Employee(string name, string dept, int salary)
        {
            this.name = name;
            this.dept = dept;
            this.salary = salary;
            subordinates = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            subordinates.Add(employee);
        }

        public void Remove(Employee employee)
        {
            subordinates.Remove(employee);
        }

        public List<Employee> GetSubordinates()
        {
            return subordinates;
        }

        public string ToString()
        {
            return "Employee: " + name + ", dept: " + dept + ", salary: " + salary + " ]";
        }
    }
}
