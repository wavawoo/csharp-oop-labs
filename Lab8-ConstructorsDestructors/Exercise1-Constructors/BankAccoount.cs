using System;

namespace FileDetails
{
    class CreateAccount
    {
        static void Main()
        {
            // Демонстрация работы различных конструкторов класса BankAccount
            BankAccount acc1 = new BankAccount(); // Конструктор по умолчанию

            BankAccount acc2 = new BankAccount(AccountType.Deposit); // Конструктор с типом счета

            BankAccount acc3 = new BankAccount(100m); // Конструктор с начальным балансом

            BankAccount acc4 = new BankAccount(AccountType.Deposit, 500m); // Конструктор с типом и балансом

            // Вывод информации о созданных счетах
            Console.WriteLine("Информация о банковских счетах:");
            Console.WriteLine($"Счет 1: №{acc1.Number()}, Тип: {acc1.Type()}, Баланс: {acc1.Balance()}");
            Console.WriteLine($"Счет 2: №{acc2.Number()}, Тип: {acc2.Type()}, Баланс: {acc2.Balance()}");
            Console.WriteLine($"Счет 3: №{acc3.Number()}, Тип: {acc3.Type()}, Баланс: {acc3.Balance()}");
            Console.WriteLine($"Счет 4: №{acc4.Number()}, Тип: {acc4.Type()}, Баланс: {acc4.Balance()}");
        }

        // Старый метод создания счета через ввод данных 
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();
            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());
            return created;
        }

        // Вспомогательный метод для вывода информации о счете
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }

        // Методы для тестирования операций пополнения и снятия
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }

        public static void Testwithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Withdraw(amount);
        }
    }
}
