namespace Utils
{
    using System;
    using System.Buffers;

    class Utils
    {
        // Проверка поддержки объектом интерфейса IFormattable
        public static bool IsItFormattable(object x)
        {
            // Использование оператора is для проверки реализации интерфейса
            if (x is IFormattable)
                return true;
            else
                return false;
        }

        // Возвращает большее из двух целых чисел
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        // Обмен значений двух целых чисел
        public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        // Вычисление факториала (итеративная версия)
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f;
            bool ok = true;

            if (n < 0)
                ok = false;

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }

            answer = f;
            return ok;
        }

        // Вычисление факториала (рекурсивная версия)
        public static bool RecursiveFactorial(int n, out int f)
        {
            bool ok = true;

            if (n < 0)
            {
                f = 0;
                ok = false;
            }

            if (n <= 1)
                f = 1;
            else
            {
                try
                {
                    int pf;
                    checked
                    {
                        ok = RecursiveFactorial(n - 1, out pf);
                        f = n * pf;
                    }
                }
                catch (Exception)
                {
                    f = 0;
                    ok = false;
                }
            }

            return ok;
        }

        // Универсальный метод для отображения объектов
        public static void Display(object item)
        {
            // Попытка преобразовать объект к интерфейсу IPrintable с помощью оператора as
            IPrintable ip = item as IPrintable;

            if (ip != null)
            {
                // Если объект поддерживает IPrintable, используем его метод Print
                ip.Print();
            }
            else
            {
                // Иначе используем стандартный метод ToString()
                Console.WriteLine(item.ToString());
            }
        }
    }
}
