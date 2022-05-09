using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 0;
            int maxValue = 31;
            int[] array = new int[30];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(minValue,maxValue);
                Console.Write(array[i] + " ");
            }

            if (array[0] > array[1])
            {
                Console.WriteLine($"\nПервый локальный максимум{array[0]}");
            }

            if (array[array.GetLength(0) - 1] > array[array.GetLength(0) - 2])
            {
                Console.WriteLine($"Последный лоскальный максимум: {array[array.GetLength(0) - 1]}");
            }

            for (int i = 1; i < array.GetLength(0) - 1; i++)
            {

                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    Console.WriteLine($"Локальный максимум: {array[i]}");
                }
            }
        }
    }
}