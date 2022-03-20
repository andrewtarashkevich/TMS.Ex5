using System;

namespace Ex._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 1 2 3 4 5 - 4 5 1 2 3
            //Задание 4 Math.Ceiling((double)arr.Length/2)
            int[] arr = new int[] { 1, 2, 3, 4,5};
            for (int i = 0; i < arr.Length/2; i++)
            {                 
                int temp = arr[i];
                arr[i] = arr[(int)Math.Ceiling((double)arr.Length / 2) + i];
                arr[(int)Math.Ceiling((double)arr.Length / 2) + i] = temp;
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
