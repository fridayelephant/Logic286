using System;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Tools
    {
        public static void CetakArray2D(string[,] array)
        {
            Console.WriteLine($"Deret Angkanya adalah: ");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write($"{array[row, col]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
