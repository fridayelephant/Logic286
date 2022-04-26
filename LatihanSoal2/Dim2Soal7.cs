using Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal2
{
    public class Dim2Soal7
    {
        public Dim2Soal7()
        {
            Console.WriteLine("== Soal no.7 ==");
            Console.Write("Masukan jumlah N (banyaknya kolom per-baris): ");
            int n1 = int.Parse(Console.ReadLine());
            int baris1 = 3;
            int baris2 = n1;
            int baris3 = 2 * n1;
            string[,] array2D = new string[baris1, n1];
            for (int row = 0; row < baris1; row++)
            {
                for(int col = 0; col < n1; col++)
                {
                    if (row == 0)
                        array2D[row, col] = col.ToString();
                    else if (row == 1)
                    {
                        array2D[row, col] = Math.Pow(n1, col).ToString();
                        baris2++;
                    }
                    else
                        array2D[row, col] = col.ToString();
                }
            }
            Tools.CetakArray2D(array2D);
        }
    }
}
