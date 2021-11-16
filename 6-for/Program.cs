using System;

namespace _6_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; double s = 0;

            Console.Write("Введите А: ");
            a = int.Parse(Console.ReadLine()); // значение
            Console.Write("Введите В: ");
            b = int.Parse(Console.ReadLine()); // значение

            if(a > b)
            {
                Console.WriteLine("Значение А больше В");
            };
            for (int i = a; i <= b; i++) // выполняем от а до б
            {
                s += Math.Pow(i, 2);
            };
            Console.WriteLine($"Квадрат всех чисел: {s}\nКорень квадрата: {Math.Sqrt(s)}");
            Console.ReadLine(); // задерживаем
        }
    }
}
