using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal3
{
    public class StairCase
    {
        public StairCase()
        {
            Console.Clear();
            Console.WriteLine("=== Staircase Maker Program ===");
            Console.Write("Input angka: ");
            int inputAngka = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputAngka; i++)
            {
                for (int j =0; j < inputAngka; j++)
                {
                    if ((i + j) >= inputAngka - 1)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Your Staircase has been created ;)");
            Console.WriteLine("\nPress any key to Continue");
            Console.ReadKey();
        }
    }
}
