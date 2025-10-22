using System;

namespace UniversityLibrary
{
    public class Textbook : Book  // Учебник наследуется от класса Book
    {
        public string Course { get; private set; }  // Учебный курс, для которого предназначен учебник

        public Textbook(string title, string author, int year, string itemId, string isbn, int pages, string course)
            : base(title, author, year, itemId, isbn, pages)  // Вызов конструктора родительского класса Book
        {
            Course = course;  // Инициализация учебного курса
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Учебник: {Title}");  
            Console.WriteLine($"Автор: {Author}");   
            Console.WriteLine($"Курс: {Course}");   
            Console.WriteLine($"Год: {Year}");   
            Console.WriteLine($"ISBN: {ISBN}");     
            Console.WriteLine($"Страниц: {Pages}");  
            Console.WriteLine($"ID: {ItemId}");      // Внутренний идентификатор
            Console.WriteLine($"Статус: {(IsAvailable() ? "Доступен" : "Выдан")}");  
            if (!IsAvailable())
            {
                Console.WriteLine($"Читатель: {CurrentBorrower}");        // Идентификатор читателя
                Console.WriteLine($"Вернуть до: {DueDate:dd.MM.yyyy}");   // Дата возврата
            }
            Console.WriteLine("-------------------"); 
        }
    }
}
