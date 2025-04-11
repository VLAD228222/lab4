using System;

namespace Variant4Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Зміна заголовка вікна
            Console.Title = "Дейко Влад - Варіант 4";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Автор програми: Дейко Влад");
            Console.WriteLine("Варіант: 4");
            Console.ResetColor();

            // Введення A з перевіркою
            double A;
            Console.Write("\nВведіть дійсне число A: ");
            bool isValid = double.TryParse(Console.ReadLine(), out A);

            if (!isValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка: некоректне введення числа.");
                Console.ResetColor();
                return;
            }

            // Обчислення x
            double x = ((A + 1.6) * 7.2) / 3.8;

            // Контрольні питання
            Console.WriteLine("\nПеред виведенням результату, дайте відповіді на 2 питання:");
            Console.Write("1. Який оператор вибору використовується у цій програмі? ");
            string ans1 = Console.ReadLine().ToLower();

            Console.Write("2. Який ще оператор вибору ви знаєте? ");
            string ans2 = Console.ReadLine().ToLower();

            if (!(ans1.Contains("if") && (ans2.Contains("if") || ans2.Contains("switch"))))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nТреба вивчити оператори вибору.");
                Console.ResetColor();
                return;
            }

            // Обчислення y
            double y = 0;
            if (x <= 0 || x > 12)
                y = 2 * x + 8.5;
            else if (x > 0 && x < 3)
                y = Math.Pow(-6 * x + 5, 5);
            else if (x >= 3 && x <= 12)
                y = Math.Sqrt(x + 6);

            // Виведення результатів
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nРезультати обчислень:\nX = {x:F3}\nY = {y:F3}");
            Console.ResetColor();

            // Очікування дій користувача перед закриттям
            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
