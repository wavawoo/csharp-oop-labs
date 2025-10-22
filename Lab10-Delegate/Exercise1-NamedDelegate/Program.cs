using System;
using System.IO;

namespace OopLabs.Delegates
{
    class Program
    {
        private delegate void Log(string message); // Объявление делегата для логирования

        static void Main()
        {
            DoSomething(LogToFile); // Вызов метода с передачей функции логирования в файл
            Console.ReadKey(); // Ожидание нажатия клавиши перед завершением
        }

        static void DoSomething(Log log)
        {
            log(DateTime.Now + ": log message"); // Вызов делегата с текущим временем и сообщением
        }

        static void LogToFile(string message)
        {
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Получение пути к папке "Мои документы"
            string logFilePath = Path.Combine(myDocsPath, "log.txt"); // Формирование полного пути к файлу лога
            File.AppendAllText(logFilePath, message + Environment.NewLine); // Добавление сообщения в конец файла
        }
    }
}
