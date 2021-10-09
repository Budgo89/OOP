using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class BankAccount
    {
        private long accountNumber;
        private double balance;
        private BankAccountType bankAccount;
        private static long number = 1;

        public void AccountNumber()
        {
            accountNumber = NewAccountNumber();
        }

        public void Balance(double _balance)
        {
            balance = _balance;
        }

        public void BankAccountType(int _bankAccount)
        {
            bankAccount = (BankAccountType)_bankAccount;
        }

        public void PrintData()
        {
            Console.WriteLine($"Номер счёта: {accountNumber}");
            Console.WriteLine($"Ваш баланс: {balance} руб.");
            Console.WriteLine($"Тип карта: {bankAccount}");
        }
        private long NewAccountNumber()
        {
            return number++;
        }

    }
}
