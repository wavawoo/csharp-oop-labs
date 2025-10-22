namespace Utils
{
    using System;

    // Класс координат, реализующий интерфейс IPrintable
    class Coordinate : IPrintable
    {
        private double x;  // Координата X
        private double y;  // Координата Y

        // Конструктор по умолчанию
        public Coordinate()
        {
            x = 0.0;
            y = 0.0;
        }

        // Конструктор с параметрами
        public Coordinate(double px, double py)
        {
            x = px;
            y = py;
        }

        // Реализация метода Print из интерфейса IPrintable
        public void Print()
        {
            Console.WriteLine("({0},{1})", x, y);  // Вывод координат в формате (X,Y)
        }
    }
}
