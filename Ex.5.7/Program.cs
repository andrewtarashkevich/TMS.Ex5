using System;

namespace Ex._5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //В массиве из целочисленных элементов (включая отрицательные) вычислить:
            //а) минимальный по модулю элемент массива;
            //б) сумму элементов, расположенных после первого нулевого элемента (элемента, равного нулю).
            //Сделать одним проходом цикла!
            int[] arr = new int[] { -8,-2,0,1,2,3};
            int min = Math.Abs(arr[0]);
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) < min) min = Math.Abs(arr[i]);
                if (arr[i] == 0)
                {
                    for (int j = i; j < arr.Length; j++) sum += arr[j];                   
                }                   
            }
            Console.WriteLine($"Минимальный эл-т по модулю {min} , Сумма {sum} ");
        }
    }
}
