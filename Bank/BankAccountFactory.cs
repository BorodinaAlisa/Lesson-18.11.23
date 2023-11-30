using System;
using System.Collections.Generic;

namespace Bank
{
    public class BankAccountFactory
    {
        private Dictionary<int, AccountBank> accountTable;

        public BankAccountFactory()
        {
            accountTable = new Dictionary<int, AccountBank>();
        }

        public int GetAccountCounter()
        {
            return AccountBank.accountCounter;
        }

        public int CreateAccount(double balance, AccountType type)
        {
            AccountBank account = new AccountBank(balance, type);
            int accountNumber = account.GetAccountNumber();
            accountTable.Add(accountNumber, account);
            return accountNumber;
        }

        public void CloseAccount(int accountNumber)
        {
            if (accountTable.ContainsKey(accountNumber))
            {
                accountTable.Remove(accountNumber);
                Console.WriteLine($"Счёт {accountNumber} закрыт.");
            }
            else
            {
                Console.WriteLine($"Счёт {accountNumber} не найден.");
            }
        }

    }
}
