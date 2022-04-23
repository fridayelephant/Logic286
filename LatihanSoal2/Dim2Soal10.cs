using Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal2
{
    public class Dim2Soal10
    {
        public Dim2Soal10()
        {
            Console.WriteLine("== Soal no.10 ==");
            Console.Write("Masukan nilai N1 (banyaknya kolom per-baris): ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Masukan nilai N2 (angka pengkali): ");
            int n2 = int.Parse(Console.ReadLine());

            int baris = 3; //output deret hanya sampai 3 baris

            string[,] array2D = new string[baris, n1];
            for (int row = 0; row < baris; row++)
            {
                for (int col = 0; col < n1; col++)
                {
                    if (row == 0)
                        array2D[row, col] = col.ToString();
                    else if (row == 1)
                    {
                        array2D[row, col] = (col * n2).ToString();
                    }
                    else
                        array2D[row, col] = ((col * n2) + col).ToString();
                }
            }
            Tools.CetakArray2D(array2D);
        }
    }
}
