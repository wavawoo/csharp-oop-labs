using System;

namespace UniversityLibrary
{
    public class Book : LibraryItem
    {
        public string ISBN { get; private set; }  // Международный стандартный книжный номер
        public int Pages { get; private set; }    // Количество страниц в книге

        public Book(string title, string author, int year, string itemId, string isbn, int pages)
            : base(title, author, year, itemId)   // Вызов конструктора базового класса
        {
            ISBN = isbn;    // Уникальный идентификатор издания
            Pages = pages;  // Объем книги в страницах
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine($"ISBN: {ISBN}");      
            Console.WriteLine($"Страниц: {Pages}");   
            Console.WriteLine($"ID: {ItemId}");        // Внутренний идентификатор
            Console.WriteLine($"Статус: {(IsAvailable() ? "Доступна" : "Выдана")}");
            if (!IsAvailable())
            {
                Console.WriteLine($"Читатель: {CurrentBorrower}");     // Кто взял книгу
                Console.WriteLine($"Вернуть до: {DueDate:dd.MM.yyyy}"); // Крайний срок возврата
            }
            Console.WriteLine("-------------------");  
        }
    }
}
