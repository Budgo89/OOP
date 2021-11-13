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
            #region DZ 4
            //#region Task 1
            //var bank1 = new BankAccount(200.3, 0);
            //bank1.PrintData();
            //var bank2 = new BankAccount(5007.3, 1);
            //bank2.PrintData();

            //Console.WriteLine();

            //bank1.MoneyTransfer(bank2, 3000);
            //Console.WriteLine();
            //bank1.PrintData();
            //bank2.PrintData();

            //bank1.MoneyTransfer(bank2, 3000);
            //Console.WriteLine();
            //bank1.PrintData();
            //bank2.PrintData();

            //bank2.MoneyTransfer(bank1, 6000);
            //Console.WriteLine();
            //bank1.PrintData();
            //bank2.PrintData();
            //#endregion
            //#region Tesk 2
            //var taskTwo = new TaskTwo();

            //string _srting1 = "QWERTY";
            //Console.WriteLine(_srting1);
            //string _srting2 = taskTwo.Flipper(_srting1);
            //Console.WriteLine(_srting2);

            //#endregion
            //#region Tesk 3
            //string filename = "Lesson3Task2.txt";
            //var taskThree = new TaskThree();
            //taskThree.TaskThreeStart(filename);
            //Console.WriteLine();
            //#endregion

            //#region Tesk 4

            //Creator.CreateBuild(10, 80, 2, 27);
            //Creator.CreateBuild(10, 120, 3, 28);
            //Creator.Print(1);
            //Console.WriteLine();
            //Creator.Print(2);
            //Creator.Delete(1);
            //Creator.Print(2);

            //#endregion

            #endregion

            #region DZ 5.1

            var bank1 = new BankAccount(200.3, 0);
            var bank2 = new BankAccount(200.3, 0);
            var bank3 = new BankAccount(200.3, 1);
            var bank4 = new BankAccount(100, 0);
            Console.WriteLine(bank1);
            Console.WriteLine(bank2);
            Console.WriteLine(bank3);
            Console.WriteLine(bank4);
            Console.WriteLine(bank1==bank1);
            Console.WriteLine(bank1 != bank1);
            Console.WriteLine(bank1 == bank2);
            Console.WriteLine(bank1 != bank2);
            Console.WriteLine(bank1.Equals(bank2));
            Console.WriteLine(bank1==bank3);
            Console.WriteLine(bank1 != bank3);
            Console.WriteLine(bank1.Equals(bank3));
            Console.WriteLine(bank1==bank4);
            Console.WriteLine(bank1 != bank4);
            Console.WriteLine(bank1.Equals(bank4));
            #endregion

            Console.ReadKey();
        }
    }
}
