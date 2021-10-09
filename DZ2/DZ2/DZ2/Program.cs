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
            bank.AccountNumber(1531856);
            bank.Balance(55240.30);
            bank.BankAccountType(1);
            bank.PrintData();

            Console.ReadKey();
        }
    }
}
