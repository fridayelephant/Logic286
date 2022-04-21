using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal
{
    public class Dim1Soal1
    {
        public Dim1Soal1()
        {
            // Soal 01, n=7, [1 3 5 6 9 11 13]
            Console.Clear();
            Console.Write("Nilai N : ");
            int n = int.Parse(Console.ReadLine());

            int nilai = 1;
            for(int i = 0; i < n; i++)
            {
                Console.Write(nilai + "\t");
                nilai = nilai + 2;
            }
            Console.WriteLine();
        }
    }
}
