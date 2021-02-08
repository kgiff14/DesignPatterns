using FilterDemo.Filters.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilterDemo.Filters.Implementations
{
    public class SingleCriteria : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();

            foreach (Person person in persons)
            {
                if (person.GetMaritalStatus().ToLower().Contains("single"))
                {
                    singlePersons.Add(person);
                }
            }

            return singlePersons;
        }
    }
}
