using System;

namespace UniversityLibrary
{
    public abstract class LibraryItem : ILendable
    {
        public string Title { get; protected set; }           // Название библиотечного материала
        public string Author { get; protected set; }          // Автор или создатель материала
        public int Year { get; protected set; }               // Год издания или публикации
        public string ItemId { get; protected set; }          // Уникальный идентификатор в системе
        public bool IsBorrowed { get; protected set; }        // Флаг статуса выдачи (true если выдан)
        public string CurrentBorrower { get; protected set; } // ID текущего читателя (null если доступен)
        public DateTime? DueDate { get; protected set; }      // Дата возврата (null если не выдан)

        protected LibraryItem(string title, string author, int year, string itemId)
        {
            Title = title;
            Author = author;
            Year = year;
            ItemId = itemId;
            IsBorrowed = false;      // Новый материал изначально доступен
            CurrentBorrower = null;  // Пока никто не взял
            DueDate = null;          // Дата возврата не установлена
        }

        // Абстрактный метод для отображения информации - должен быть реализован в наследниках
        public abstract void DisplayInfo();

        // Реализация методов интерфейса
        public virtual void Lend(string borrowerId, DateTime dueDate)
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                CurrentBorrower = borrowerId;
                DueDate = dueDate;
                Console.WriteLine($"{Title} выдан читателю {borrowerId}. Дата возврата: {dueDate:dd.MM.yyyy}");
            }
            else
            {
                Console.WriteLine($"{Title} уже выдан другому читателю."); // Материал уже занят
            }
        }

        public virtual void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"{Title} возвращен в библиотеку.");
                CurrentBorrower = null;  // Сбрасываем информацию о читателе
                DueDate = null;          // Сбрасываем дату возврата
            }
            else
            {
                Console.WriteLine($"{Title} уже находится в библиотеке."); // Ничего не делаем
            }
        }

        public virtual bool IsAvailable()
        {
            return !IsBorrowed; // Доступен если не выдан
        }
    }
}
