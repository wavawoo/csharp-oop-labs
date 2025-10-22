using System;

namespace FileDetails
{
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }

        public long Number() { return accNo; }
        public decimal Balance() { return accBal; }
        public string Type() { return accType.ToString(); }

        private static long nextAccNo = 123;
        private static long NextNumber() { return nextAccNo++; }

    }
}
