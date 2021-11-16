using System;

namespace _10_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0; 

            Console.Write("Введите число: ");
            n = int.Parse(Console.ReadLine()); // считываем

            for (int i = n; i > 0; i = i / 10) // делаем рекурсию и сокращаем каждый раз число
            {
                s = s + i % 10;
            }
            Console.WriteLine("Сумма числа: {0}", s);
            Console.ReadLine(); // задерживаем
        }
    }
}
