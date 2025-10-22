namespace Utils
{
    using System;

    class Utils
    {
        // Возвращает большее из двух целых чисел
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        // Обмен значений двух целых чисел (передача по ссылке)
        public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        // Вычисление факториала с возвратом результата через out-параметр
        public static bool Factorial(int n, out int answer)
        {
            int k;        // Счетчик цикла
            int f;        // Рабочее значение
            bool ok = true; // Флаг успешности операции

            // Проверка входного значения (факториал определен для n >= 0)
            if (n < 0)
                ok = false;

            try
            {
                checked  // Блок для проверки переполнения
                {
                    f = 1;
                    // Вычисление факториала: произведение чисел от 2 до n
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                // Обработка переполнения или других ошибок
                f = 0;
                ok = false;
            }

            answer = f;   // Возврат результата через out-параметр
            return ok;    // Возврат статуса операции
        }

        // Рекурсивное вычисление факториала
        public static bool RecursiveFactorial(int n, out int f)
        {
            bool ok = true;

            // Проверка отрицательного ввода
            if (n < 0)
            {
                f = 0;
                ok = false;
            }

            // Базовый случай рекурсии
            if (n <= 1)
                f = 1;
            else
            {
                try
                {
                    int pf;
                    checked
                    {
                        // Рекурсивный вызов для n-1
                        ok = RecursiveFactorial(n - 1, out pf);
                        f = n * pf;  // n! = n * (n-1)!
                    }
                }
                catch (Exception)
                {
                    // Обработка ошибок
                    f = 0;
                    ok = false;
                }
            }

            return ok;
        }

        // Проверка, поддерживает ли объект интерфейс IFormattable
        public static bool IsItFormattable(object x)
        {
            // Использование оператора is для проверки реализации интерфейса
            return x is IFormattable;
        }
    }
}
