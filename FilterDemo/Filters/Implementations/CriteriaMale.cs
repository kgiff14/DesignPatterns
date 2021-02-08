using FilterDemo.Filters.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilterDemo.Filters.Implementations
{
    public class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();

            foreach(Person person in persons)
            {
                if (person.GetGender().ToLower().Contains("male") && !person.GetGender().ToLower().Contains("female"))
                {
                    malePersons.Add(person);
                }
            }

            return malePersons;
        }
    }
}
