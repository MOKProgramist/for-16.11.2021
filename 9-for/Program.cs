using System;

namespace _9_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 200; (i % 17) != 0; i++)
            {
                Console.WriteLine(i); 
            }
            Console.ReadLine(); // задерживаем
        }
    }
}
