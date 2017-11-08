using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            char[] toEncrypt = new char[n];
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                toEncrypt[i] = char.Parse(Console.ReadLine());

                result += Encrypt(toEncrypt[i]);
            }

            Console.WriteLine(result);

        }
        static string Encrypt(char toEncrypt)
        {

            byte FU = ((byte)toEncrypt);
            string sfu = FU.ToString();
            int lenfu = sfu.Length;
            byte fst = byte.Parse(sfu[0].ToString());
            byte lst = byte.Parse(sfu[lenfu - 1].ToString());

            char cfst = (char)(FU + lst);
            char clst = (char)(FU - fst);
            string sresult = string.Format("{0}{1}{2}{3}", cfst, fst.ToString(), lst.ToString(), clst);
            //Console.WriteLine(sresult);
          return sresult;
           
        }
    }
}
