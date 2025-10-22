using System.Collections;

class BankAccount
{
    private long accNo;        // Номер счета
    private decimal accBal;     // Баланс счета
    private AccountType accType; // Тип счета

    // Статическая переменная для генерации уникальных номеров счетов
    private static long nextNumber = 123;

    // Очередь для хранения транзакций по счету
    private Queue tranQueue = new Queue();

    // Метод для получения очереди транзакций
    public Queue Transactions()
    {
        return tranQueue;
    }

    // Конструктор по умолчанию - создает счет типа Checking с нулевым балансом
    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0m;
    }

    // Конструктор с указанием типа счета - баланс инициализируется нулем
    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = 0m;
    }

    // Конструктор с указанием начального баланса - тип счета Checking
    public BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = aBal;
    }

    // Конструктор с указанием типа счета и начального баланса
    public BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = aBal;
    }

    // Снятие денег со счета
    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount; // Проверка достаточности средств
        if (sufficientFunds)
        {
            accBal -= amount; // Снятие денег при наличии средств

            // Создаем транзакцию с отрицательной суммой (снятие)
            BankTransaction transaction = new BankTransaction(-amount);
            tranQueue.Enqueue(transaction); // Добавляем транзакцию в очередь
        }

        return sufficientFunds; // Возвращаем результат операции
    }

    // Пополнение счета
    public decimal Deposit(decimal amount)
    {
        // Создаем транзакцию с положительной суммой (пополнение)
        BankTransaction transaction = new BankTransaction(amount);
        tranQueue.Enqueue(transaction); // Добавляем транзакцию в очередь

        accBal += amount; // Увеличение баланса
        return accBal; // Возвращаем новый баланс
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
