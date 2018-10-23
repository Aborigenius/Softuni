using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class Family
    {
        //Fields
        private List<Person> familyMembers;

        //Constuctors
        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }

        public List<Person> FamilyMembers
        {
            get { return this.familyMembers; }
            set { this.familyMembers = value; }
        }

        //Methods
        public void AddMember(Person member)
        {
            if (member == null)
            {
                throw new Exception();
            }
            this.FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.FamilyMembers.OrderByDescending(x => x.Age).FirstOrDefault();
        }

    }
}
