using System;

namespace Chapter1
{
    class BookFirstChapters
    {
        static void Main(string[] args)
        {
            var d = DateTime.Now;
            Console.WriteLine($"Current Time is: {d}");
            Console.WriteLine("Enter a number to square it:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Math Sqrt of {num} is:" + " " + Math.Sqrt(num));

            int currentPosNum = 2;
            int currentNegNum = -3;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(currentPosNum + " " + currentNegNum);
                currentPosNum += 2;
                currentNegNum += -2;
            }

            char symbol = 'A';
            Console.WriteLine($"Numeric Code f {symbol} is {(int)symbol}");

            Console.WriteLine($"Int to Char example {(char)65}");
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i -= 2)
            {
                string spaces = new String(' ', (number - i) / 2);
                Console.WriteLine(spaces + new String('*', i) + spaces);
            }
            if (number % 2 == 0)
            {
                Console.WriteLine(new String(' ', (number) / 2) + '#');
            }
            else
            {
                Console.WriteLine(new String(' ', (number) / 2 + 1) + '#');
            }
                
           
            for (int i = 1; i <= number; i+=2)
            {
                string spaces = new String(' ', (number - i) / 2) + '#';
                Console.WriteLine(spaces + new String(' ', i) + '#');
            }
            Console.WriteLine(new string('#', number + 3));
        }

    }
}
