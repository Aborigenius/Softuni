using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string intInput = Console.ReadLine();
            int[] intArray = intInput.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            byte[] asciiInput = Encoding.ASCII.GetBytes(strInput).ToArray();
            byte[] myResultArray = new byte[intArray.Length];
            for ( int i= 0, j =0; i < asciiInput.Length; i++, j++)
            {
                    if (intArray[j] % 2 == 0)
                    {
                        myResultArray[i] = (byte)(asciiInput[i] - intArray[j]);
                    }
                    else
                    {
                        myResultArray[i] = (byte)(asciiInput[i] + intArray[j]);
                    }
            }
            string result = System.Text.Encoding.UTF8.GetString(myResultArray);
            Console.WriteLine(result);
        }
    }
}
