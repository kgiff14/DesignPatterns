using System;
using System.Collections.Generic;
using System.Text;

namespace FilterDemo.Filters.Interface
{
    public interface ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons);
    }
}
