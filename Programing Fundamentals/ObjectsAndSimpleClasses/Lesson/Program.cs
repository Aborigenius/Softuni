using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Pesho = new Hero
            {
                SecretName = "Super Pesho",
                SuperPower = "Rakia Drinking",
                Age = 73
            };

            Hero Gosho = new Hero
            {
                SecretName = "Super Gosho",
                SuperPower = "Vodka Drinking",
                Age = 89
            };

            List <Hero>heroes = new List<Hero>();
            heroes.Add(Pesho);
            heroes.Add(Gosho);

            foreach (Hero hero in heroes)
            {
                Console.WriteLine(hero.SecretName + " <=> " + hero.SuperPower);
            }

          
        }
    }
    class Hero
    {
        public string SecretName { get; set; }
        public string SuperPower { get; set; }
        public int Age { get; set; }
    }
}