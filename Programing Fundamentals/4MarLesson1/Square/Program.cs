using System;

public class Program
{
    public static void Main()
    {
        //Console.Write("How many stars you want today (2 to 100):"); //friendly question, doesn't work in judge
        var n = int.Parse(Console.ReadLine()); //Define Variable

        if (n >= 2 && n - 2 <= 100) // Check is variable between 2 and 100 and if it is do...
        {
            Console.WriteLine(new string('*', n)); //print * n times - top row of stars 

            for (int i = 0; i < n - 2; i++) //if i is 0 or less than var n -2 add

                Console.WriteLine("*" + new string(' ', n - 2) + "*"); //print left column *, print empty space and remove 2 to make it look right add right column *

            Console.WriteLine(new string('*', n)); //print * n times - bottom row of stars
        }

        else
        {
            Console.WriteLine("Not between 2 - 100!");
        }


    }
}