using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static string[] phoneNumbers;
        static string[] names;

        static void Main(string[] args)
        {
            phoneNumbers = Console.ReadLine().Split(' ');
            names = Console.ReadLine().Split(' ');

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "done")
            {
                string command = input[0];
                string argument = input[1];
                string name = string.Empty;
                string number = String.Empty;
                string output = string.Empty;

                if (IsNumber(argument) == true)
                {
                    name = GetInputType(argument); ;
                    number = argument;
                    output = name;
                }
                else
                {
                    name = argument;
                    number = GetInputType(argument); ;
                    output = number;
                }
                int digitSum = GetDigitsSum(number);
                if (command == "call")
                {
                    Console.WriteLine($"calling {output}...");
                    if (digitSum % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int minutes = digitSum / 60;
                        int seconds = digitSum % 60;
                        Console.WriteLine($"call ended. duration: {minutes:d2}:{seconds}");
                    }

                }
                else if (command == "message")
                {
                    Console.WriteLine($"sending sms to {output}...");
                    if (digitSum % 2 == 1)
                    {

                        Console.WriteLine($"busy");
                    }
                    else
                    {
                        Console.WriteLine($"meet me there");
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
        static int GetDigitsSum(string phoneNumber)
        {
            int sum = 0;
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (IsDigit(phoneNumber[i]))
                {
                    sum += phoneNumber[i] - 0;
                }
            }
            return sum;
        }
        static string GetInputType(string input)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == input)
                {
                    return names[i];
                }
                else if (phoneNumbers[i] == input)
                {
                    return phoneNumbers[i];
                }
            }
            return string.Empty;
        }

        static bool IsNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (IsDigit(input[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsDigit(char symbol)
        {
            return (symbol >= 0 && symbol <= 9);
        }
    }
}