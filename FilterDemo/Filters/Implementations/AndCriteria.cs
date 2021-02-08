using FilterDemo.Filters.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilterDemo.Filters.Implementations
{
    public class AndCriteria : ICriteria
    {
        private ICriteria criteria { get; set; }
        private ICriteria otherCriteria { get; set; }

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = criteria.MeetCriteria(persons);
            return otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}
