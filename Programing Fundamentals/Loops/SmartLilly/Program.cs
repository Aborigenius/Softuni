using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int LillyAge = int.Parse(Console.ReadLine());
            double laundryMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            var evenBday = 0.00;
            var oddBday = 0.00;
            var plus10 = 0.00;
            double moneyreceived = 0.00;
            
            for (int i = 1; i <= LillyAge; i++)
            {
                if (i % 2 == 0)
                {
                    
                    plus10 += 10;
                    moneyreceived = plus10 + moneyreceived;
                    evenBday++;
                }
                else
                {
                    oddBday++;
                }
            }
            var toysMoney = (oddBday * toyPrice);
            moneyreceived = (moneyreceived + toysMoney) - evenBday;
            Console.WriteLine(moneyreceived);
            
            if (moneyreceived >= laundryMachine)
            {
                var diff = moneyreceived - laundryMachine;
                Console.WriteLine("Yes! {0:F2}", diff);
            }
            else
            {
                var diff = laundryMachine - moneyreceived;
                Console.WriteLine("No! {0:F2} ", diff);
            }
        }
    }
}
