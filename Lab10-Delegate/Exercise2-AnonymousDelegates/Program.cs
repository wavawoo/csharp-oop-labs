using System;
using System.IO;

namespace OopLabs.Delegates
{
    class Program
    {
        private delegate void Log(string message); // Объявление делегата для обработки строковых сообщений

        static void Main()
        {
            DoSomething(LogToFile); // Передача именованного метода для записи в файл
            DoSomething(delegate (string message) { Console.WriteLine(message); }); // Анонимный делегат с явным объявлением
            DoSomething(message => Console.WriteLine(message)); // Лямбда-выражение как компактная форма анонимного делегата
            DoSomething(Console.WriteLine); // Передача готового метода в качестве делегата
            Console.ReadKey(); // Ожидание пользовательского ввода перед закрытием
        }

        static void DoSomething(Log log)
        {
            log(DateTime.Now + ": log message"); // Формирование и передача сообщения с временной меткой в делегат
        }

        static void LogToFile(string message)
        {
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Получение пути к папке "Мои документы"
            string logFilePath = Path.Combine(myDocsPath, "log.txt"); // Создание полного пути к файлу лога
            File.AppendAllText(logFilePath, message + Environment.NewLine); // Добавление сообщения с переводом строки в конец файла
        }
    }
}
