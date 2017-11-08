using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

          Random rnd = new Random(13);
          for (int i = 0; i < words.Length; i++)
          {
                int index = rnd.Next(0, words.Length);

                string temp = words[i];
                words[i] = words[index];
                words[index] = temp;
          }

            words.ToList().ForEach(Console.WriteLine);

       //  WebClient webClient = new WebClient();
       //  webClient.DownloadFile("https://softuni.bg/trainings/resources/officedocument/16726/presentation-programming-fundamentals-extended-may-2017", "pr.pdf");
       //  WebProxy wp = new WebProxy("http://proxy:8080");
       //  webClient.Proxy = wp;


        }

   
    }
}
