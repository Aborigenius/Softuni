using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var groupType = Console.ReadLine().ToLower();
            int studentsNumber = int.Parse(Console.ReadLine());
            int nigthsNumber = int.Parse(Console.ReadLine());
            double something = 0;
            string sport = "";

            if (groupType == "boys" || groupType == "girls")
            {
                if (studentsNumber >= 50 && season == "Winter")
                {
                    something = ((studentsNumber * 9.60) * nigthsNumber) / 2;
                }
                if (studentsNumber >= 20 && studentsNumber < 50)
                {
                   
                }
                if (studentsNumber >= 10 && studentsNumber < 20)
                {
                    Console.WriteLine("10-20");
                }
                else
                {

                }
            }
            if (groupType == "mixed")
            {
                if (season == "Winter")
                {
                    sport = "Ski";
                }
                if (season == "Spring")
                {
                    sport = "Cycling";
                }
                if (season == "Summer")
                {
                    sport = "Swimming";
                }
            }
           
        }
    }
}
