using FilterDemo.Filters.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilterDemo.Filters.Implementations
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();

            foreach (Person person in persons)
            {
                if (person.GetGender().ToLower().Contains("female"))
                {
                    femalePersons.Add(person);
                }
            }

            return femalePersons;
        }
    }
}
