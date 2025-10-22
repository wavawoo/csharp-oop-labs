using System;
using System.Collections.Generic;

namespace UniversityLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityLibrary library = new UniversityLibrary();

            // Создание различных типов материалов - ХУДОЖЕСТВЕННАЯ ЛИТЕРАТУРА
            Book book1 = new Book("Мастер и Маргарита", "Михаил Булгаков", 1967, "B001", "978-5-389-12345-1", 480);
            Book book2 = new Book("1984", "Джордж Оруэлл", 1949, "B002", "978-5-389-12345-2", 328);
            Book book3 = new Book("Три товарища", "Эрих Мария Ремарк", 1936, "B003", "978-5-389-12345-3", 480);
            Book book4 = new Book("Маленький принц", "Антуан де Сент-Экзюпери", 1943, "B004", "978-5-389-12345-4", 96);
            Book book5 = new Book("Сто лет одиночества", "Габриэль Гарсиа Маркес", 1967, "B005", "978-5-389-12345-5", 544);

            // НАУЧНАЯ ЛИТЕРАТУРА И УЧЕБНИКИ
            Textbook textbook1 = new Textbook("Основы программирования на C#", "Иванов А.В.", 2023, "T001", "978-5-389-12345-6", 420, "Информатика");
            Textbook textbook2 = new Textbook("Высшая математика для технических вузов", "Сидоров П.С.", 2022, "T002", "978-5-389-12345-7", 560, "Математика");
            Textbook textbook3 = new Textbook("Общая физика: Механика", "Петрова Е.К.", 2021, "T003", "978-5-389-12345-8", 380, "Физика");
            Textbook textbook4 = new Textbook("Органическая химия", "Козлов Д.М.", 2023, "T004", "978-5-389-12345-9", 450, "Химия");
            Textbook textbook5 = new Textbook("Экономика предприятия", "Николаева С.В.", 2022, "T005", "978-5-389-12346-0", 320, "Экономика");

            // СПРАВОЧНАЯ ЛИТЕРАТУРА
            Reference reference1 = new Reference("Справочник по математическому анализу", "Лебедев А.Н.", 2021, "R001", "978-5-389-12346-1", 620, "Математика");
            Reference reference2 = new Reference("Физический энциклопедический словарь", "Фролов И.П.", 2020, "R002", "978-5-389-12346-2", 780, "Физика");
            Reference reference3 = new Reference("Справочник химических элементов", "Менделеев Д.И.", 2019, "R003", "978-5-389-12346-3", 540, "Химия");
            Reference reference4 = new Reference("Англо-русский технический словарь", "Васильев К.Л.", 2022, "R004", "978-5-389-12346-4", 890, "Лингвистика");
            Reference reference5 = new Reference("Справочник по электротехнике", "Вольтов А.С.", 2021, "R005", "978-5-389-12346-5", 670, "Электротехника");

            // Добавление материалов в библиотеку - ХУДОЖЕСТВЕННАЯ ЛИТЕРАТУРА
            library.AddItem(book1);
            library.AddItem(book2);
            library.AddItem(book3);
            library.AddItem(book4);
            library.AddItem(book5);

            // Добавление УЧЕБНИКОВ
            library.AddItem(textbook1);
            library.AddItem(textbook2);
            library.AddItem(textbook3);
            library.AddItem(textbook4);
            library.AddItem(textbook5);

            // Добавление СПРАВОЧНИКОВ
            library.AddItem(reference1);
            library.AddItem(reference2);
            library.AddItem(reference3);
            library.AddItem(reference4);
            library.AddItem(reference5);

            // Отображение всех материалов
            library.DisplayAllItems();

            // Выдача материалов студентам
            Console.WriteLine("\nВЫДАЧА МАТЕРИАЛОВ СТУДЕНТОВ");
            library.LendItem("T001", "ST2024001", DateTime.Now.AddDays(14));
            library.LendItem("T002", "ST2024002", DateTime.Now.AddDays(21));
            library.LendItem("R001", "ST2024003", DateTime.Now.AddDays(30));
            library.LendItem("B001", "ST2024004", DateTime.Now.AddDays(7));

            // Отображение доступных материалов
            library.DisplayAvailableItems();

            // Отображение выданных материалов
            library.DisplayBorrowedItems();

            // Поиск материалов по различным критериям
            Console.WriteLine("\nПОИСК МАТЕРИАЛОВ ПО АВТОРУ 'Иванов'");
            var ivanovBooks = library.FindItemsByAuthor("Иванов");
            foreach (var item in ivanovBooks)
            {
                item.DisplayInfo();
            }

            Console.WriteLine("\nПОИСК МАТЕРИАЛОВ ПО НАЗВАНИЮ 'математика'");
            var mathItems = library.FindItemsByTitle("математика");
            foreach (var item in mathItems)
            {
                item.DisplayInfo();
            }

            // Статистика библиотеки
            library.DisplayLibraryStatistics();
        }
    }
}
