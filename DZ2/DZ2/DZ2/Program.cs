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


            Console.ReadKey();
        }
    }
}
