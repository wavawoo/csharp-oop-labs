using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityLibrary
{
    public class UniversityLibrary
    {
        private List<LibraryItem> items;  // Коллекция всех библиотечных материалов

        public UniversityLibrary()
        {
            items = new List<LibraryItem>();  // Инициализация пустой коллекции при создании библиотеки
        }

        public void AddItem(LibraryItem item)
        {
            items.Add(item);  // Добавление нового материала в коллекцию
            Console.WriteLine($"Добавлен: {item.GetType().Name} - {item.Title}");  // Подтверждение добавления
        }

        public void DisplayAllItems()
        {
            Console.WriteLine("\nВСЕ МАТЕРИАЛЫ БИБЛИОТЕКИ");  // Заголовок раздела
            foreach (var item in items)
            {
                item.DisplayInfo();  // Отображение информации о каждом материале
            }
        }

        public void DisplayAvailableItems()
        {
            Console.WriteLine("\nДОСТУПНЫЕ МАТЕРИАЛЫ");  // Заголовок для доступных материалов
            var availableItems = items.Where(item => item.IsAvailable());  // Фильтрация доступных материалов

            if (!availableItems.Any())  // Проверка наличия доступных материалов
            {
                Console.WriteLine("Нет доступных материалов.");  // Сообщение если ничего не доступно
                return;
            }

            foreach (var item in availableItems)
            {
                item.DisplayInfo();  // Отображение информации о доступных материалах
            }
        }

        public void DisplayBorrowedItems()
        {
            Console.WriteLine("\nВЫДАННЫЕ МАТЕРИАЛЫ");  // Заголовок для выданных материалов
            var borrowedItems = items.Where(item => !item.IsAvailable());  // Фильтрация выданных материалов

            if (!borrowedItems.Any())  // Проверка наличия выданных материалов
            {
                Console.WriteLine("Нет выданных материалов.");  // Сообщение если ничего не выдано
                return;
            }

            foreach (var item in borrowedItems)
            {
                item.DisplayInfo();  // Отображение информации о выданных материалах
            }
        }

        public LibraryItem FindItemById(string itemId)
        {
            return items.Find(item => item.ItemId == itemId);  // Поиск материала по уникальному идентификатору
        }

        public List<LibraryItem> FindItemsByTitle(string title)
        {
            return items.FindAll(item =>
                item.Title.Contains(title, StringComparison.OrdinalIgnoreCase));  // Поиск по названию (без учета регистра)
        }

        public List<LibraryItem> FindItemsByAuthor(string author)
        {
            return items.FindAll(item =>
                item.Author.Contains(author, StringComparison.OrdinalIgnoreCase));  // Поиск по автору (без учета регистра)
        }

        public void LendItem(string itemId, string borrowerId, DateTime dueDate)
        {
            var item = FindItemById(itemId);  // Поиск материала по ID
            if (item != null)
            {
                item.Lend(borrowerId, dueDate);  // Выдача материала если найден
            }
            else
            {
                Console.WriteLine($"Материал с ID {itemId} не найден.");  // Сообщение об ошибке
            }
        }

        public void ReturnItem(string itemId)
        {
            var item = FindItemById(itemId);  // Поиск материала по ID
            if (item != null)
            {
                item.Return();  // Возврат материала если найден
            }
            else
            {
                Console.WriteLine($"Материал с ID {itemId} не найден.");  // Сообщение об ошибке
            }
        }

        public int GetTotalItemsCount()
        {
            return items.Count;  // Общее количество материалов в библиотеке
        }

        public int GetAvailableItemsCount()
        {
            return items.Count(item => item.IsAvailable());  // Количество доступных материалов
        }

        public int GetBorrowedItemsCount()
        {
            return items.Count(item => !item.IsAvailable());  // Количество выданных материалов
        }

        public void DisplayLibraryStatistics()
        {
            Console.WriteLine("\nСтатистика библиотеки");  // Заголовок статистики
            Console.WriteLine($"Всего материалов: {GetTotalItemsCount()}");  // Общее количество
            Console.WriteLine($"Доступно: {GetAvailableItemsCount()}");      // Доступные материалы
            Console.WriteLine($"Выдано: {GetBorrowedItemsCount()}");         // Выданные материалы

            var itemsByType = items.GroupBy(item => item.GetType().Name)  // Группировка по типу материалов
                                  .Select(g => new { Type = g.Key, Count = g.Count() });

            Console.WriteLine("\nРаспределение по типам:");  // Заголовок распределения
            foreach (var group in itemsByType)
            {
                Console.WriteLine($"  {group.Type}: {group.Count}");  // Вывод количества по каждому типу
            }
        }
    }
}
