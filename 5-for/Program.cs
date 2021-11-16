using System;

namespace _5_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 15, do_c = 30; double f; // переменные

            for(int i = c; i <= do_c; i++)
            {
                f = (1.8 * i) + 32; // расчет температуры по фаренгейту f= 1,8c +32
                Console.WriteLine($"c = {i}\tf = {f:0.0}"); 
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
