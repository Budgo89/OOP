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

        public BankAccount()
        {

        }
        public BankAccount (double _balance)
        {
            balance = _balance;
            AccountNumbers();
        }
        public BankAccount (int _bankAccount)
        {
            bankAccount = (BankAccountType)_bankAccount;
            AccountNumbers();
        }
        public BankAccount (double _balance, 
                            int _bankAccount)
        {
            balance = _balance;
            bankAccount = (BankAccountType)_bankAccount;
            AccountNumbers();
        }

        public long AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
        }

        public BankAccountType BankAccounts
        {
            get
            {
                return this.bankAccount;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        private void AccountNumbers()
        {
            accountNumber = NewAccountNumber();
        }

        public void PrintData()
        {
            Console.WriteLine($"Номер счёта: {accountNumber}");
            Console.WriteLine($"Ваш баланс: {balance} руб.");
            Console.WriteLine($"Тип карта: {bankAccount}");
            Console.WriteLine();
        }
        private long NewAccountNumber()
        {
            return number++;
        }
        public void Withdraw(double sum)
        {
            if (sum > balance)
            {
                Console.WriteLine("На вашем счету недостаточно денег");
            }
            else
            {
                balance = balance - sum;
                Console.WriteLine("Операция выполнена");
            }
        }
        public void ToDeposit(double sum)
        {
            balance = balance + sum;
            Console.WriteLine("Операция выполнена");
        }
    }
}
