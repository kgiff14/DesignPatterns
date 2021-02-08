using FilterDemo.Filters.Implementations;
using FilterDemo.Filters.Interface;
using System;
using System.Collections.Generic;

namespace FilterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Bob", "Male", "Single"));
            persons.Add(new Person("Bobbie", "Female", "Single"));
            persons.Add(new Person("Jim", "Male", "Married"));
            persons.Add(new Person("Jenny", "Female", "Single"));
            persons.Add(new Person("Chris", "Male", "Single"));
            persons.Add(new Person("Heather", "Female", "Married"));
            persons.Add(new Person("Kim", "Female", "Single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new SingleCriteria();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleFemale = new AndCriteria(single, female);

            Console.WriteLine("Males: ");
            PrintPersons(male.MeetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            PrintPersons(female.MeetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            PrintPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("\nSingle Females: ");
            PrintPersons(singleFemale.MeetCriteria(persons));
        }

        public static void PrintPersons(List<Person> persons)
        {
            foreach(Person person in persons)
            {
                Console.WriteLine("Person: [Name: " + person.GetName() + ", Gender: " + person.GetGender() + ", Marital Status: " + person.GetMaritalStatus() + " ]");
            }
        }
    }
}
