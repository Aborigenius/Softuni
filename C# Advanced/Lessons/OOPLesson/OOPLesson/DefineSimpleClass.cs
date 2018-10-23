using System;

namespace OOPLesson
{
    public class DefineSimpleClass
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(999);
            bankAccount.Withdraw(1500);
            Console.WriteLine(bankAccount.Balance);
        }
    }
}
