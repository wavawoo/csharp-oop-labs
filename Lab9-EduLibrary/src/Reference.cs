using System;

namespace UniversityLibrary
{
    public class Reference : Book  // Справочник наследуется от класса Book
    {
        public string Subject { get; private set; }  // Предметная область справочника

        public Reference(string title, string author, int year, string itemId, string isbn, int pages, string subject)
            : base(title, author, year, itemId, isbn, pages)  // Вызов конструктора базового класса Book
        {
            Subject = subject;  // Инициализация предметной области
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Справочник: {Title}"); 
            Console.WriteLine($"Автор: {Author}");     
            Console.WriteLine($"Предмет: {Subject}");   
            Console.WriteLine($"Год: {Year}");      
            Console.WriteLine($"ISBN: {ISBN}");       
            Console.WriteLine($"Страниц: {Pages}");    
            Console.WriteLine($"ID: {ItemId}");         // Внутренний идентификатор в системе
            Console.WriteLine($"Статус: {(IsAvailable() ? "Доступен" : "Выдан")}");  
            if (!IsAvailable())
            {
                Console.WriteLine($"Читатель: {CurrentBorrower}");        // ID читателя, взявшего справочник
                Console.WriteLine($"Вернуть до: {DueDate:dd.MM.yyyy}");   // Крайний срок возврата
            }
            Console.WriteLine("-------------------"); 
        }
    }
}
