using FilterDemo.Filters.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilterDemo.Filters.Implementations
{
    public class OrCriteria : ICriteria
    {
        private ICriteria criteria { get; set; }
        private ICriteria otherCriteria { get; set; }

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = otherCriteria.MeetCriteria(persons);

            foreach(Person person in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }
    }
}
