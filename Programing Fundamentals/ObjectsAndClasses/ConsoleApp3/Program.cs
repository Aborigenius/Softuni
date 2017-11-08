using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

        public Website(string host, string domain, List<string> queries)
        {
            this.Host = host;
            this.Domain = domain;
            this.Queries = queries;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Website> sites = new List<Website>();
            while (input != "end")
            {
                string[] inputTokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string host = inputTokens[0];
                string domain = inputTokens[1];

                List<string> queries;
                if (inputTokens.Length > 2)
                {
                    queries = inputTokens[2].Split(new string[] { "," },
                 StringSplitOptions.RemoveEmptyEntries).ToList();

                }
                else
                {
                    queries = new List<string>();
                }

                sites.Add(new Website(host, domain, queries));

                input = Console.ReadLine();
            }
            foreach (var item in sites)
            {
                if (item.Queries.Count != 0)
                {
                    Console.Write($"https://www.{item.Host}.{item.Domain}/query?=");
                    foreach (var host in item.Queries)
                    {
                        string last = item.Queries.Last();
                        if (host != last)
                        {
                            Console.Write($"[{host}]&");
                        }
                        else
                        { Console.Write($"[{host}]"); }
                        
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"https://www.{item.Host}.{item.Domain}");
                }
            }
        }
    }

}
