using System;

namespace Ex._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Слить два целочисленных массива в один (должен получиться третий массив).
            //Задание 3
            int[] arr1 = new int[] { 0,1,2,4,5};
            int[] arr2 = new int[] { 6,7,8,9};
            int[] arr_result = new int[arr1.Length+arr2.Length];
            for (int j = 0,i=0; j < arr1.Length; j++,i++)
            {
                arr_result[i] = arr1[j];
            }

            for (int j = 0, i = arr1.Length; j < arr2.Length; j++, i++)
            {
                arr_result[i] = arr2[j];
            }            

            for (int i = 0; i < arr_result.Length; i++)
            {
                Console.Write($"{ arr_result[i]} ");
            }
        }
    }
}
