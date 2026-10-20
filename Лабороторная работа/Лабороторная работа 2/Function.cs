using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабороторная_работа_2
{
    static class Functions
    {

        static string[] names = { "велосипед", "самокат", "ролики", "лыжи", "скейтборд" };
        static int[] prices = { 1200, 700, 450, 1600, 950 };
        static int[] counts = { 12, 20, 15, 8, 10 };
    }

     public static void PrintPark()
        {
            Console.WriteLine("Парк проката:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} — {prices[i]} руб., {counts[i]} шт.");
            }
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                    return value;
                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
    }
}

