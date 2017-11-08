using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupsNumber = int.Parse(Console.ReadLine());
            var totalPeople = 0.00;
            var car = 0.00;
            var microbus = 0.00;
            var smallbus = 0.00;
            var bus = 0.00;
            var train = 0.00;
            for (int i = 0; i < groupsNumber; i++)
            {
                var personsPerGroup = int.Parse(Console.ReadLine());

                if (personsPerGroup >= 1 && personsPerGroup <= 5)
                {
                    car = personsPerGroup + car;
                }
                else if (personsPerGroup > 5 && personsPerGroup <= 12)
                {
                    microbus = personsPerGroup + microbus;
                }
                else if (personsPerGroup > 12 && personsPerGroup <= 25)
                {
                    smallbus = personsPerGroup + smallbus;
                }
                else if (personsPerGroup > 25 && personsPerGroup <= 40)
                {
                    bus = personsPerGroup + bus;
                }
                else if (personsPerGroup > 40)
                {
                    train = personsPerGroup + train;
                }
                totalPeople += personsPerGroup;
                }
           
            Console.WriteLine($"{car/totalPeople*100:F2}%");
            Console.WriteLine($"{microbus / totalPeople * 100:F2}%");
            Console.WriteLine($"{smallbus /totalPeople*100:F2}%");
            Console.WriteLine($"{bus /totalPeople*100:F2}%");
            Console.WriteLine($"{train /totalPeople*100:F2}%");

        }
    }
}
