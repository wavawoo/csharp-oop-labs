using System;
using System.IO;

/// <summary>
/// Класс для создания копии файла с преобразованием текста в верхний регистр
/// </summary>
public class CopyFileUpper
{
    public static void Main()
    {
        string sFrom, sTo;       // Переменные для имен файлов
        StreamReader srFrom;     // Поток для чтения из исходного файла
        StreamWriter swTo;       // Поток для записи в выходной файл

        // Запрос имени исходного файла
        Console.Write("Введите имя входного файла: ");
        sFrom = Console.ReadLine();

        // Запрос имени выходного файла
        Console.Write("Введите имя выходного файла: ");
        sTo = Console.ReadLine();

        try
        {
            // Создание потоков для чтения и записи
            srFrom = new StreamReader(sFrom);
            swTo = new StreamWriter(sTo);

            // Чтение файла построчно до конца (Peek() возвращает -1 при достижении конца)
            while (srFrom.Peek() != -1)
            {
                string sBuffer = srFrom.ReadLine();  // Чтение одной строки
                sBuffer = sBuffer.ToUpper();         // Преобразование в верхний регистр
                swTo.WriteLine(sBuffer);             // Запись обработанной строки
            }

            // Закрытие потоков (освобождение ресурсов)
            srFrom.Close();
            swTo.Close();

            Console.WriteLine("Файл успешно обработан!");
        }
        catch (FileNotFoundException)
        {
            // Обработка случая, когда исходный файл не найден
            Console.WriteLine("Ошибка: входной файл не найден!");
        }
        catch (Exception e)
        {
            // Обработка всех остальных исключений
            Console.WriteLine("Ошибка: " + e.Message);
        }
    }
}
