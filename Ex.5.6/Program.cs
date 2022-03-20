using System;

namespace Ex._5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот. Сделать за O(N/2)
            //Задание 6
            int[] arr = new int[] {1,2,3,4,5 };
            for (int i = 1; i < arr.Length; i+=2)
            {
                int temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
            }
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
