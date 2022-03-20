using System;

namespace Ex5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            int sum_odd1 = 0;
            int sum_even1 = 0;
            int sum_null1 = 0;
            int[] arr1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < arr1.Length; i++)
            {
                if (i == 0) sum_null1 += 1;
                else if (i % 2 == 0) sum_even1 += 1;
                else sum_odd1 += 1;

            }
            Console.WriteLine($"Количество четный = {sum_even1}, кол-во нечетных = {sum_odd1}, кол-во нулей {sum_null1}");
        }
    }
}
