using System;
using Bank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public enum AccountType
    {
        Current,
        Savings
    }
    public class AccountBank
    {
        public static int accountCounter = 1000;// статическая переменная для генерации уникального номера счета
        private int AccountNumber;
        public double Balance;
        private AccountType AccountType;
        
        internal AccountBank(double balance, AccountType type)
        {
            GenerateAccountNumber();
            Balance = balance;
            AccountType = type;
        }

        public AccountBank(int v, AccountType current)
        {
        }

        public void GenerateAccountNumber()
        {
            AccountNumber = accountCounter;
            accountCounter++;
        }
        public int GetAccountNumber()
        {
            return AccountNumber;
        }

        public double GetBalance()
        {
            return Balance;
        }

        internal AccountType GetAccountType()
        {
            return AccountType;
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Списание {amount} выполнено.Новый баланс: {Balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Ошибка!Увеличьте сумму для списания.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Депозит на {amount} выполнен.Новый баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Ошибка!Увеличьте сумму для депозита.");
            }
        }
        public void PrintAccount()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Баланс: {Balance}");
            Console.WriteLine($"Тип счета: {AccountType}");
        }
        public static bool operator ==(AccountBank account1, AccountBank account2)
        {
            if (ReferenceEquals(account1, account2))
                return true;
            if (ReferenceEquals(account1, null) || ReferenceEquals(account2, null))
                return false;
            return account1.AccountNumber == account2.AccountNumber;
        }
        public static bool operator !=(AccountBank account1, AccountBank account2)
        {
            return !(account1 == account2);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            if (ReferenceEquals(null, obj))
                return false;
            if (GetType() != obj.GetType())
                return false;

            return this == (AccountBank)obj;
        }
        public override string ToString()
        {
            return $"Номер счёта: {AccountNumber}";
        }
    }
}
