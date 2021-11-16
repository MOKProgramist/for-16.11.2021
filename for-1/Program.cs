using System;

namespace for_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, n = 0; // переменные

            Console.Write("Введите число A: ");
            a = int.Parse(Console.ReadLine()); // считываем значение

            Console.Write("Введите число B: ");
            b = int.Parse(Console.ReadLine()); // считываем значение
            
            if(a > b)
            {
                Console.WriteLine("Число А больше В");
            };

            for(i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                n++; // количество
            };
            Console.WriteLine($"Количество: {n}");
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
