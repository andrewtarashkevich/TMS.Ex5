using System;

namespace Ex._5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отсортировать массив по возрастанию алгоритмом выборки (select).
            int[] arr = new int[] { 3, 0, -2, 2, 1, -8 };

			for (int i = 0; i < arr.Length; i++)
			{
				int min = i;
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j].CompareTo(arr[min]) < 0)
					{
						min = j;
					}
				}

				var temp = arr[i];
				arr[i] = arr[min];
				arr[min] = temp;
			}

			Console.WriteLine(string.Join(", ", arr));
		}
    }
}
