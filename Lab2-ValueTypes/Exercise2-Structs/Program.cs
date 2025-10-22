using System;

public enum AccountType
{
    Checking,
    Deposit
}
public struct BankAccount
{
    public long accNo;
    public decimal accBal;
    public AccountType accType;
}

class StructType
{
    static void Main(string[] args)
    {
        BankAccount goldAccount;

        goldAccount.accNo = 1234567890L;
        goldAccount.accBal = 555.55m;
        goldAccount.accType = AccountType.Checking;

        Console.WriteLine("Account Number: " + goldAccount.accNo);
        Console.WriteLine("Account Balance: " + goldAccount.accBal);
        Console.WriteLine("Account Type: " + goldAccount.accType);
    }
}
