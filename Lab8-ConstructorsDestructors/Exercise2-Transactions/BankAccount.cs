using System.Collections;

class BankAccount
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextNumber = 123;

    // Очередь для хранения истории транзакций
    private Queue tranQueue = new Queue();

    // Метод для получения доступа к очереди транзакций извне класса
    public Queue Transactions()
    {
        return tranQueue;
    }

    // Конструкторы остаются без изменений
    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0m;
    }

    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = 0m;
    }

    public BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = aBal;
    }

    public BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = aBal;
    }

    // Снятие денег со счета
    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
            // Создание транзакции на снятие (отрицательная сумма)
            BankTransaction transaction = new BankTransaction(-amount);
            tranQueue.Enqueue(transaction);  // Добавление транзакции в очередь
        }
        return sufficientFunds;
    }

    // Пополнение счета
    public decimal Deposit(decimal amount)
    {
        // Создание транзакции на пополнение (положительная сумма)
        BankTransaction transaction = new BankTransaction(amount);
        tranQueue.Enqueue(transaction);  // Добавление транзакции в очередь

        accBal += amount;
        return accBal;
    }

    // Получение номера счета
    public long Number()
    {
        return accNo;
    }

    // Получение текущего баланса
    public decimal Balance()
    {
        return accBal;
    }

    // Получение типа счета в виде строки
    public string Type()
    {
        return accType.ToString();
    }

    // Генерация следующего номера счета
    private static long NextNumber()
    {
        return nextNumber++;
    }

    // Перевод денег с другого счета на текущий
    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
        {
            this.Deposit(amount);
        }
    }
}
