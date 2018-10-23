using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int inputN = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputN; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);


            }

            //Person oldestPerson = family.GetOldestMember();

            foreach (var person in family.FamilyMembers.Where(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
