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

        static int ReadTransportNumber()
        {
            while (true)
            {
                int num = ReadInt("Введите номер транспорта (0 — конец заказа): ");
                if (num == 0) return 0;
                if (num >= 1 && num <= names.Length) return num;
                Console.WriteLine($"Ошибка: номер должен быть от 1 до {names.Length} или 0.");
            }
        }

        static int ReadQuantity()
        {
            while (true)
            {
                int qty = ReadInt("Введите количество: ");
                if (qty >= 0) return qty;
                Console.WriteLine("Ошибка: количество не может быть отрицательным.");
            }
        }
        static int CheckAvailability(int[] ordered)
        {
            for (int i = 0; i < counts.Length; i++)
                if (ordered[i] > counts[i]) return i;
            return -1;
        }
        static int CalculateCost(int[] ordered)
        {
            int total = 0;
            for (int i = 0; i < prices.Length; i++)
                total += prices[i] * ordered[i];
            return total;
        }

    }
}

