using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new BankAccount();
            bank.PrintData();

            var bank1 = new BankAccount(5007.3);
            bank1.PrintData();

            var bank2 = new BankAccount(2);
            bank2.PrintData();

            var bank3 = new BankAccount(5007.3, 1);
            bank3.PrintData();

            Console.WriteLine(bank3.AccountNumber);
            Console.WriteLine(bank3.Balance + 1000);
            Console.WriteLine(bank3.BankAccounts);
            Console.WriteLine();

            bank3.Withdraw(1500);
            bank3.PrintData();

            bank3.Withdraw(15000);
            bank3.PrintData();

            bank3.ToDeposit(10257.35);
            bank3.PrintData();

            Console.ReadKey();
        }
    }
}
