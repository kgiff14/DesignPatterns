using System;
using System.Collections.Generic;
using System.Text;

namespace FilterDemo
{
    public class Person
    {
        private string name { get; set; }
        private string gender { get; set; }
        private string maritalStatus { get; set; }

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }

        public string GetName()
        {
            return name;
        }

        public string GetGender()
        {
            return gender;
        }

        public string GetMaritalStatus()
        {
            return maritalStatus;
        }
    }
}
