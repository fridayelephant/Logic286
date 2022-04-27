using System;
using System.Collections.Generic;
using System.Text;

namespace Day05
{
    public class Gemstone
    {
        public Gemstone()
        {
            Console.Clear();
            Console.WriteLine("=== GEMSTONE===");

            string tmp = "";
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input[0].Length; i++)
            {
                for (int j = 0; j < input[1].Length; j++)
                {
                    for (int k = 0; k < input[2].Length; k++)
                    {
                        if (input[0][i] == input[1][j] && input[1][j] == input[2][k])
                        {
                            if (tmp.IndexOf(input[0][i]) == -1)
                                tmp += input[0][i];
                        }
                    }
                }
            }

            Console.WriteLine(tmp);
            Console.WriteLine($"Jumlah {tmp.Length}");
            Console.WriteLine("\nPress....");
            Console.ReadLine();
        }
    }
}
