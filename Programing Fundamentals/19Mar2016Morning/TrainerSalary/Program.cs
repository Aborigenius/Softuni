using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainersalary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lectureNumber = int.Parse(Console.ReadLine());
            var Jelev = 0;
            var RoYal = 0;
            var Roli = 0;
            var Trofon = 0;
            var Sino = 0;
            var guests = 0;

            var availBudget = double.Parse(Console.ReadLine());

            for (int i = 0; i < lectureNumber; i++)
            {
                var lector = Console.ReadLine().ToLower();
                if (lector == "jelev")
                {
                    Jelev++;
                }
                else if (lector == "royal")
                {
                    RoYal++;
                }
                else if (lector == "roli")
                {
                    Roli++;
                }
                else if (lector == "trofon")
                {
                    Trofon++;
                }
                else if (lector == "sino")
                {
                    Sino++;
                }
                else
                {
                    guests++;
                }
            }


            var moneyPerLecture = availBudget / lectureNumber;

            Console.WriteLine($"Jelev salary: {Jelev * moneyPerLecture:F2} lv");
            Console.WriteLine($"RoYaL salary: {RoYal * moneyPerLecture:F2} lv");
            Console.WriteLine($"Roli salary: {Roli * moneyPerLecture:F2} lv");
            Console.WriteLine($"Trofon salary: {Trofon * moneyPerLecture:F2} lv");
            Console.WriteLine($"Sino salary: {Sino * moneyPerLecture:F2} lv");
            Console.WriteLine($"Others salary: {guests * moneyPerLecture:F2} lv");



        }
    }
}
