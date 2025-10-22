using System;
using System.Collections;

namespace FileDetails
{
    class CreateAccount
    {
        static void Main()
        {
            // Создание счетов с помощью различных конструкторов
            BankAccount acc1 = new BankAccount();
            BankAccount acc2 = new BankAccount(AccountType.Deposit);
            BankAccount acc3 = new BankAccount(100m);
            BankAccount acc4 = new BankAccount(AccountType.Deposit, 500m);

            // Выполнение операций по счетам для создания транзакций
            acc1.Deposit(200m);
            acc1.Withdraw(40m);

            acc2.Deposit(200m);
            acc2.Withdraw(100m);

            acc3.Deposit(150m);
            acc3.Withdraw(55m);

            acc4.Deposit(404m);
            acc4.Withdraw(200m);

            // Вывод информации о счетах вместе с историей транзакций
            Console.WriteLine("Информация о банковских счетах:");
            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);
        }

        // Вспомогательный метод для вывода информации о счете
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());

            // Вывод истории транзакций
            Console.WriteLine("Transaction history:");
            Queue transactions = toWrite.Transactions();  // Получаем очередь транзакций
            foreach (BankTransaction tran in transactions)  // Итерация по всем транзакциям
            {
                Console.WriteLine("  Date/Time: {0}, Amount: {1}",
                    tran.When(), tran.Amount());  // Вывод даты и суммы каждой транзакции
            }
            Console.WriteLine();
        }

        // Методы для интерактивного тестирования
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
