using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OpinionPoll
{
    public class Members
    {
        private List<Person> members;

        public Members()
        {
            this.Peoples = new List<Person>();
        }

        public List<Person> Peoples
        {
            get { return members; }
            set { members = value; }
        }

        public List<Person> GetMembers()
        {
            var result = this.Peoples.Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            return result;

        }

        public void AddMembers(Person member)
        {

            members.Add(member);

        }
    }
}
