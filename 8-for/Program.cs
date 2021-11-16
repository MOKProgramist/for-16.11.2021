using System;

namespace _8_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0, x = 1;

            Console.WriteLine("Постфиксная форма y = y + x++;");
            for(int i = 0; i < 10; i++)
            {
                y = y + x++;
                Console.WriteLine($"y = {y}");
            };
            y = 0;
            x = 1;

            Console.WriteLine("Префиксная  форма y = y + ++х;");
            for (int i = 0; i < 10; i++)
            {
                y = y + ++x;
                Console.WriteLine($"y = {y}");
            }

            Console.ReadLine(); // задерживаем
        }
    }
}
