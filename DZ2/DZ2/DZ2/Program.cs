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
            bank.AccountNumber();
            bank.Balance(55240.30);
            bank.BankAccountType(1);
            bank.PrintData();
            var bank1 = new BankAccount();
            bank1.AccountNumber();
            bank1.Balance(55240.30);
            bank1.BankAccountType(1);
            bank1.PrintData();
            var bank2 = new BankAccount();
            bank2.AccountNumber();
            bank2.Balance(55240.30);
            bank2.BankAccountType(1);
            bank2.PrintData();




            Console.ReadKey();
        }
    }
}
