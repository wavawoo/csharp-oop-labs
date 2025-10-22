class BankAccount
{
    private long accNo;          // Номер счета
    private decimal accBal;      // Баланс счета
    private AccountType accType; // Тип счета

    private static long nextNumber = 123; // Статическая переменная для генерации номеров счетов

    // Инициализация счета с указанным балансом
    public void Populate(decimal balance)
    {
        accNo = NextNumber();    // Генерация уникального номера
        accBal = balance;        // Установка баланса
        accType = AccountType.Checking; // По умолчанию текущий счет
    }

    // Снятие денег со счета
    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount; // Проверка достаточности средств
        if (sufficientFunds)
        {
            accBal -= amount; // Снятие денег при наличии средств
        }
        return sufficientFunds;
    }

    // Пополнение счета
    public decimal Deposit(decimal amount)
    {
        accBal += amount; // Увеличение баланса
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
        // Сначала снимаем деньги с исходного счета
        if (accFrom.Withdraw(amount))
        {
            this.Deposit(amount); // Если снятие успешно, пополняем текущий счет
        }
    }
}
