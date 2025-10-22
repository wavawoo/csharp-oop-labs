using System;

namespace UniversityLibrary
{
    // Интерфейс для объектов, которые могут быть выданы во временное пользование
    public interface ILendable
    {
        void Lend(string borrowerId, DateTime dueDate); // Выдать материал читателю
        void Return(); // Принять возвращенный материал от читателя
        bool IsAvailable(); // Проверить, доступен ли материал для выдачи
    }
}
