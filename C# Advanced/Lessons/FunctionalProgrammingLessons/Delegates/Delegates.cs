using System;


namespace Delegates
{
    class Delegates
    {
        public delegate string BinaryOperator(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine(Calc(4, 5, Multiply));
            Console.WriteLine(Calc(4, 5, Add));
            Console.WriteLine(Calc(4, 5, IsGreater));
        }

        public static string Calc(int x ,int y, BinaryOperator oper)
        {
            return oper(x, y);
        }

        public static string Multiply(int x, int y)
        {
            return (x * y).ToString();
        }

        public static string Add (int x, int y)
        {
            return (x + y).ToString();
        }

        public static string IsGreater (int x, int y)
        {
            return (x > y).ToString();
        }
    }
}
