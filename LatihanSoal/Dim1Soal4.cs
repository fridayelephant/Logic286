using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal
{
    public class Dim1Soal4
    {
        public Dim1Soal4()
        {
            // Soal 01, n=7, [1 5 9 13 17 21 25]
            Console.Clear();
            Console.Write("Nilai N : ");
            int n = int.Parse(Console.ReadLine());

            int nilai = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(nilai + "\t");
                nilai = nilai + 4;
            }
            Console.WriteLine();
        }
    }
}
