using System;
using System.Collections;

namespace FileDetails
{
    class CreateAccount
    {
        static void Main()
        {
            // Создаем банковский счет с конструктором по умолчанию
            BankAccount acc1 = new BankAccount();

            // Тестируем операции пополнения и снятия для создания транзакций
            acc1.Deposit(1000m);
            acc1.Withdraw(250m);

            Console.WriteLine("Информация о банковском счете:");
            Write(acc1); // Выводим информацию о счете и его транзакциях

            /*
            BankAccount acc2 = new BankAccount(AccountType.Deposit);
            BankAccount acc3 = new BankAccount(100m);
            BankAccount acc4 = new BankAccount(AccountType.Deposit, 500m);

            Console.WriteLine("Информация о банковских счетах:");
            Console.WriteLine($"Счет 1: №{acc1.Number()}, Тип: {acc1.Type()}, Баланс: {acc1.Balance()}");
            Console.WriteLine($"Счет 2: №{acc2.Number()}, Тип: {acc2.Type()}, Баланс: {acc2.Balance()}");
            Console.WriteLine($"Счет 3: №{acc3.Number()}, Тип: {acc3.Type()}, Баланс: {acc3.Balance()}");
            Console.WriteLine($"Счет 4: №{acc4.Number()}, Тип: {acc4.Type()}, Баланс: {acc4.Balance()}");
            

            acc1.Deposit(200m);
            acc1.Withdraw(40m);
            
            acc2.Deposit(200m);
            acc2.Withdraw(100m);

            acc3.Deposit(150m);
            acc3.Withdraw(55m);

            acc4.Deposit(404m);
            acc4.Withdraw(200m);

            Console.WriteLine("Информация о банковских счетах:");
            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);
            */
        }

        // Метод для вывода подробной информации о банковском счете
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());

            Console.WriteLine("Transaction history:");
            // Получаем очередь транзакций для данного счета
            Queue transactions = toWrite.Transactions();

            // Перебираем все транзакции и выводим их детали
            foreach (BankTransaction tran in transactions)
            {
                Console.WriteLine("  Date/Time: {0}, Amount: {1}",
                    tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }

        // Вспомогательные методы для тестирования
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
