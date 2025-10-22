using System;

public class BankTransaction
{
    private readonly decimal amount;  // Сумма транзакции (только для чтения)
    private readonly DateTime when;   // Время транзакции (только для чтения)

    // Конструктор транзакции - инициализирует сумму и фиксирует текущее время
    public BankTransaction(decimal tranAmount)
    {
        amount = tranAmount;
        when = DateTime.Now;  // Фиксируем момент создания транзакции
    }

    // Метод доступа для получения суммы транзакции
    public decimal Amount()
    {
        return amount;
    }

    // Метод доступа для получения времени транзакции
    public DateTime When()
    {
        return when;
    }
}
