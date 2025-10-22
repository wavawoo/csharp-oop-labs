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
            // Создание тестовых переменных разных типов
            int i = 0;
            ulong ul = 0;
            string s = "Test";

            // Проверка каждой переменной на поддержку интерфейса IFormattable
            Console.WriteLine(Utils.IsItFormattable(i));   // true - числа поддерживают форматирование
            Console.WriteLine(Utils.IsItFormattable(ul));  // true - числа поддерживают форматирование
            Console.WriteLine(Utils.IsItFormattable(s));   // false - строки не поддерживают форматирование
        }
    }
}
