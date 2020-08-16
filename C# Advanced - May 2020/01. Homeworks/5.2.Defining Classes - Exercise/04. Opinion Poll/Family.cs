using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOlderstMember()
        {
            return people.OrderByDescending(a => a.Age).FirstOrDefault();
        }
    }
}
