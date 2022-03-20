using System;

namespace Ex._5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Циклически двинуть массив вправо на 1 элемент. Например: 1 2 3 4 5 -> 5 1 2 3 4. А после этого сделать циклический сдвиг вправо на N элементов.
            //Задание 5
            int[] array = { 3, 5, 7, 9, 11, 13 };
            int k = 0;
            int[] arraynew = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arraynew[(i + k) % arraynew.Length] = array[i];
            }
            Console.WriteLine(string.Join(", ", arraynew));            
        }
    }
}
