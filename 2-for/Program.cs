using System;

namespace _2_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, i = 0; // переменне

            for(i = a; i <= 20; i++) // пока i != 20
            {
                Console.WriteLine($"{i} в квадрате = {Math.Pow(i, 2)}");
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
