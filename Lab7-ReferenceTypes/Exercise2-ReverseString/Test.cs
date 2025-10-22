namespace Utils
{
    using System;

    /// <summary>
    ///   Тестовый класс для проверки утилит
    /// </summary>
    public class Test
    {
        public static void Main()
        {
            string message = Console.ReadLine();  // Чтение строки из консоли
            Utils.Reverse(ref message);           // Вызов метода для обращения строки (передача по ссылке)
            Console.WriteLine(message);           // Вывод результата
        }
    }
}
