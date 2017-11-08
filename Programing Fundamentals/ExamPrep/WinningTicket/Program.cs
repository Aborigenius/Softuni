using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tickets = Regex.Split(Console.ReadLine(), @"\s*,\s*").Select(t => t.Trim()).Where(t => t.Length > 0)
                .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string ticketLeftSide = ticket.Substring(0, 10);
                    string ticketRightSide = ticket.Substring(10);

                    //                    Console.WriteLine($"TicketLeft: {ticketLeftSide}");
                    //         Console.WriteLine($"Ticket Right: {ticketRightSide}");

                    var leftSeq = FindMaxSeq(ticketLeftSide);
                    var rightSeq = FindMaxSeq(ticketRightSide);

           //                   Console.WriteLine($"LeftSeq {leftSeq}");
             //                Console.WriteLine($"RightSeq {rightSeq}");

                    //if left/right match is 6 or more and first symbol[0] matches(left and right)
                    if (leftSeq.Length >= 6 && rightSeq.Length >= 6
                        && leftSeq[0] == rightSeq[0])
                    {
                        var count = Math.Min(leftSeq.Length, rightSeq.Length);
                        Console.Write($"ticket \"{ticket}\" - {count}{leftSeq[0]}");
                        if (count == 10)
                        {
                            Console.Write(" Jackpot!");

                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }

        static string FindMaxSeq(string s)
        {
            string matched = String.Empty;
            Regex pattern = new Regex(@"(?<match>([#|$|^|@]){6,10})");
            Match m = pattern.Match(s);
            if (m.Success)
            {
                matched = m.Value;

            }
            return matched;
        }
    }
}
//'@', '#', '$' and '^' [#|$|^|@]{6,10}