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
            this.FamilYMembrers = new List<Person>();
        }

        public List<Person> FamilYMembrers
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
            this.FamilYMembrers.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.FamilYMembrers.OrderByDescending(x => x.Age).FirstOrDefault();
        }

          
    }
}
