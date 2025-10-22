using System;

enum AccountType
{
    Checking,
    Deposit
}
class BankAccount
{
    static void Main(string[] args)
    {
        AccountType goldAccount;
        AccountType platinumAccount;

        goldAccount = AccountType.Checking;
        platinumAccount = AccountType.Deposit;

        Console.WriteLine("Gold Account Type: " + goldAccount);
        Console.WriteLine("Platinum Account Type: " + platinumAccount);
    }
}
