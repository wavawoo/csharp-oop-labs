using System;

/// <summary>
/// Тестовый класс для проверки работы с банковскими счетами.
/// </summary>
public class Test
{
    public static void Main()
    {
        // Создаем два банковских счета
        BankAccount b1 = new BankAccount();
        BankAccount b2 = new BankAccount();

        // Инициализируем счета начальным балансом 100
        b1.Populate(100m);
        b2.Populate(100m);

        // Выводим информацию о счетах до перевода
        Console.WriteLine("До перевода:");
        Console.WriteLine($"Счет 1: №{b1.Number()}, Тип: {b1.Type()}, Баланс: {b1.Balance()}");
        Console.WriteLine($"Счет 2: №{b2.Number()}, Тип: {b2.Type()}, Баланс: {b2.Balance()}");

        // Выполняем перевод 10 единиц со второго счета на первый
        b1.TransferFrom(b2, 10m);

        // Выводим информацию о счетах после перевода
        Console.WriteLine("\nПосле перевода:");
        Console.WriteLine($"Счет 1: №{b1.Number()}, Тип: {b1.Type()}, Баланс: {b1.Balance()}");
        Console.WriteLine($"Счет 2: №{b2.Number()}, Тип: {b2.Type()}, Баланс: {b2.Balance()}");
    }
}
