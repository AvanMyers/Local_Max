using System;

namespace LocalMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int randomMin = 0;
            int randomMax = 10;
            int arrayElement = 30;
            string localMax = "";

            Random random = new Random();

            int[] array = new int[arrayElement];

            for (int i = 0; i < array.Length; i++)
            {
                number = random.Next(randomMin, randomMax);
                array[i] = number;
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            if (array[0] > array[1])
                localMax += Convert.ToString(array[0] + " ");

            if (array[arrayElement - 1] > array[arrayElement - 2])
                localMax += Convert.ToString(array[arrayElement - 1] + " ");

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    localMax += Convert.ToString(array[i] + " ");
            }

            Console.WriteLine(localMax);
            Console.ReadKey();
        }
    }
}
