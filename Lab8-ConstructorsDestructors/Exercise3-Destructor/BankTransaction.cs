using System;
using System.IO;

public class BankTransaction
{
    private readonly decimal amount;
    private readonly DateTime when;

    // Конструктор класса BankTransaction
    // Создает новую банковскую транзакцию с указанной суммой
    public BankTransaction(decimal tranAmount)
    {
        amount = tranAmount;
        when = DateTime.Now; // Запоминаем текущее время создания транзакции

        // Записываем информацию о транзакции в файл при ее создании
        string file = "Transactions.Dat";
        StreamWriter swFile = File.AppendText(file);
        swFile.WriteLine("Date/Time: {0}\tAmount: {1}", when, amount);
        swFile.Close();
    }

    // Метод для получения суммы транзакции
    public decimal Amount()
    {
        return amount;
    }

    // Метод для получения даты и времени транзакции
    public DateTime When()
    {
        return when;
    }

    // Деструктор - вызывается при уничтожении объекта сборщиком мусора
    ~BankTransaction()
    {
        GC.SuppressFinalize(this); // Указываем сборщику мусора не вызывать финализатор
    }
}
