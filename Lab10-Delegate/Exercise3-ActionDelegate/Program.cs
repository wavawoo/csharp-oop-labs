using System;
using System.IO;

namespace OopLabs.Delegates
{
    class Program
    {
        static void Main()
        {
            DoSomething(LogToFile); // Запись сообщения в файл через именованный метод
            DoSomething(delegate (string message) { Console.WriteLine(message); }); // Вывод в консоль через анонимный делегат
            DoSomething(message => Console.WriteLine(message)); // Вывод в консоль через лямбда-выражение
            DoSomething(Console.WriteLine); // Прямая передача метода Console.WriteLine как Action<string>
            Console.ReadKey(); // Ожидание нажатия клавиши для завершения программы
        }

        static void DoSomething(Action<string> log) // Универсальный метод, принимающий Action<string> для обработки сообщений
        {
            log(DateTime.Now + ": log message"); // Формирование сообщения с временной меткой и вызов переданного действия
        }

        static void LogToFile(string message)
        {
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Получение пути к папке "Мои документы"
            string logFilePath = Path.Combine(myDocsPath, "log.txt"); // Создание полного пути к файлу лога
            File.AppendAllText(logFilePath, message + Environment.NewLine); // Добавление сообщения с переводом строки в файл
        }
    }
}
