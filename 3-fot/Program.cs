using System;

namespace _3_fot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0, i;

            Console.Write("Введите n: ");
            n = int.Parse(Console.ReadLine()); //  значение с консоли 

            for(i = 1; i <= n; i++)
            {
                Console.WriteLine($"{s} + {i} + {s + i}");
                s = s + i;
            }
            Console.ReadLine(); // задерживаем коносль
        }
    }
}
