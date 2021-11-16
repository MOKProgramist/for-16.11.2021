using System;

namespace _7_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = -5; i <= 5; i++) // выполняем от -5 до 5
            {
                Console.WriteLine((i != 0 ? $"100/{i} = {(100 / i)}" : "На 0 делить нельзя")); // вывод в консоль тернарным оператором
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
