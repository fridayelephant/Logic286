using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal3
{
    public class PlusMinus
    {
        public PlusMinus()
        {
            Console.WriteLine("Masukan Nilai N: ");
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            float nol = 0;
            float post = 0;
            float neg = 0;

            Console.WriteLine("Masukan input: ");
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                if (input[i] == 0)
                    nol++;
                else if (input[i] < 0)
                    neg++;
                else
                    post++;
            }
            Console.WriteLine($"{post / n}\n {neg / n}\n {nol / n}");

            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
        }
    }
}
