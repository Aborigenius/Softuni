using System;

public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));
    }
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteractivly.
        for (int i = 0; i < n+1; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        
        }
        return a;
    }
}
