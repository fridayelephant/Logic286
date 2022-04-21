using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal
{
    public class Dim1Soal2
    {
        public Dim1Soal2()
        {
            // Soal 01, n=7, [2 4 6 8 10 12 14]
            Console.Clear();
            Console.Write("Nilai N : ");
            int n = int.Parse(Console.ReadLine());

            int nilai = 2;
            for (int i = 0; i < n; i++)
            {
                Console.Write(nilai + "\t");
                nilai = nilai + 2;
            }
            Console.WriteLine();
        }
    }
}
