using System;

namespace Ex._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Каждый третий элемент массива заменить суммой двух предыдущих элементов.
            //Задание 2
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Ориганальный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{ arr[i]} ");
            }
            Console.WriteLine("");
            Console.WriteLine("Обновленный массив");
            
            for (int i = 2; i < arr.Length; i+=3)
            {                
                 arr[i] = arr[i - 1] + arr[i - 2];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{ arr[i]} ");
            }
        }
    }
}
