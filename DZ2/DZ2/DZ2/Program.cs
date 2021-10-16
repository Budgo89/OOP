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
            
            var bank1 = new BankAccount(200.3, 0);
            bank1.PrintData();
            var bank2 = new BankAccount(5007.3, 1);
            bank2.PrintData();

            Console.WriteLine();

            bank1.MoneyTransfer(bank2, 3000);
            Console.WriteLine();
            bank1.PrintData();
            bank2.PrintData();

            bank1.MoneyTransfer(bank2, 3000);
            Console.WriteLine();
            bank1.PrintData();
            bank2.PrintData();

            bank2.MoneyTransfer(bank1, 6000);
            Console.WriteLine();
            bank1.PrintData();
            bank2.PrintData();

            Console.ReadKey();
        }
    }
}
