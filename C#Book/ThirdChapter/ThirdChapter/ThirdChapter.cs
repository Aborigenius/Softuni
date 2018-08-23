using System;
using System.Linq;

namespace ThirdChapter
{
    class ThirdChapter
    {
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsEven(x));

            //Console.WriteLine(Is57(x));

            //double a = 2;
            //double b = 2;
            //double h = 4; 


            //double S = ((a + b) * h) / 2;
            //Console.WriteLine(S);
            //double weight = x;
            //Console.WriteLine($"On the moon:  {weight  /100 *17} ");

            //IS INSIDE CIRCLE
            //double centerX = 0;
            //double centerY = 0;
            //double circleR = 5;

            //double pointX = double.Parse(Console.ReadLine());
            //double pointY = double.Parse(Console.ReadLine());

            //double distance = ((pointX - centerX) * (pointX - centerX)) + ((pointY - centerY) * (pointY - centerY)0);

            //if (distance < (circleR * circleR))
            //{
            //    Console.WriteLine("Inside");
            //}
            //else if (distance == (circleR * circleR))
            //{
            //    Console.WriteLine("On The circle");
            //}
            //else
            //{
            //    Console.WriteLine("OutSide");
            //}
            //IS INSIDE CIRCLE
            int num = int.Parse(Console.ReadLine());

            var numArray = num.ToString().Select(t => int.Parse(t.ToString())).ToArray();
     

            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine(Reverse(num));
            shiftLast(numArray);
            Console.WriteLine(string.Join(" ", numArray));

            Console.WriteLine($"The number {IsPrime(num)}");

        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        public static int[] shiftLast(int[] arr)
        {
            int last = arr[arr.Length - 1];
            int first = arr[0];
            arr[arr.Length - 1] = first;
            arr[0] = last;
            return arr;
        }
        public static int Reverse(int number)
        {
            return int.Parse(number.ToString().Reverse().Aggregate("", (s, c) => s + c));
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Is57(int a)
        {
            if (a % 5 == 0 && a % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
