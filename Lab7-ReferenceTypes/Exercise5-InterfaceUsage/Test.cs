namespace Utils
{
    using System;

    /// <summary>
    ///   Тестовый класс для демонстрации работы с интерфейсами
    /// </summary>
    public class Test
    {
        public static void Main()
        {
            int num = 65;                           // Целое число (не поддерживает IPrintable)
            string msg = "A String";                // Строка (не поддерживает IPrintable)
            Coordinate c = new Coordinate(21.0, 68.0);  // Координата (поддерживает IPrintable)

            // Тестирование метода Display с разными типами объектов
            Utils.Display(num);  // Вызовет ToString() для числа
            Utils.Display(msg);  // Вызовет ToString() для строки
            Utils.Display(c);    // Вызовет метод Print() интерфейса IPrintable
        }
    }
}
