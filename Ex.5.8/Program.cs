using System;

namespace Ex._5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отсортировать массив по возрастанию алгоритмом вставок (insert).
            int[] arr = new int[] { 3, 0, -2, 2, 1, -8 };            

            for (int i = 1; i < arr.Length; i++)
                for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    int temp = arr[j-1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }

            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
