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
            if (sum < balance || bankAccount==0)
            {
                balance = balance - sum;
                Console.WriteLine("Операция выполнена");
            }
            else
            {
                Console.WriteLine("На вашем счету недостаточно денег");
            }
        }
        public void ToDeposit(double sum)
        {
            balance = balance + sum;
            Console.WriteLine("Операция выполнена");
        }
        public void MoneyTransfer(BankAccount bankAccount, double sum)
        {
            if (bankAccount.balance >= sum || bankAccount.bankAccount == 0)
            {
                bankAccount.Withdraw(sum);
                ToDeposit(sum);
            }
            else
            {
                Console.WriteLine("На вашем счету недостаточно денег");
            }
        }
        public static bool operator ==(BankAccount x, BankAccount y)
        {
            return (x.accountNumber == y.accountNumber && x.balance == y.balance && x.bankAccount == y.bankAccount);
        }
        public static bool operator !=(BankAccount x, BankAccount y)
        {
            return (x.accountNumber != y.accountNumber || x.balance != y.balance || x.bankAccount != y.bankAccount);
        }
        public override bool Equals(object obj)
        {
            BankAccount y = (BankAccount)obj;
            return (this.accountNumber == y.accountNumber && this.balance == y.balance && this.bankAccount == y.bankAccount);
        }
        public override string ToString()
        {
            return $"Номер счёта: {accountNumber}; \nВаш баланс: {balance} руб.; \nТип карта: {bankAccount} \n";
        }

        public override int GetHashCode()
        {
            int hashCode = -1205030766;
            hashCode = hashCode * -1521134295 + accountNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + balance.GetHashCode();
            hashCode = hashCode * -1521134295 + bankAccount.GetHashCode();
            return hashCode;
        }
    }
}
