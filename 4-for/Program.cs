using System;

namespace _4_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine()); // считываем 

            Console.WriteLine($"Таблица умножения на {a}:");
            for(int i = 1; i <= 10; i++) // 10 повторов
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
