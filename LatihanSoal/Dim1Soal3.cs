using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal
{
    public class Dim1Soal3
    {
        public Dim1Soal3()
        {
            // Soal 01, n=7, [1 4 7 10 13 16 19]
            Console.Clear();
            Console.Write("Nilai N : ");
            int n = int.Parse(Console.ReadLine());

            int nilai = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(nilai + "\t");
                nilai = nilai + 3;
            }
            Console.WriteLine();
        }
    }
}
