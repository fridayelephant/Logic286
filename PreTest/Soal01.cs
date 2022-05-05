using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    public class Soal01
    {
        public Soal01()
        {
            //pemasukan harga
            //burger
            Console.WriteLine("Maximum dan Minimum Penjumlahan dari 2 deret");
            Console.Write("Masukan deret ke-1 (pemisah dengan spasi): ");
            string[] strDer1 = Console.ReadLine().Split(' ');

            int[] arrDer1 = Array.ConvertAll<string, int>(strDer1, int.Parse);
            //kentang
            Console.Write("Masukan deret ke-2 (pemisah dengan spasi): ");
            string[] strDer2 = Console.ReadLine().Split(' ');

            int[] arrDer2 = Array.ConvertAll<string, int>(strDer2, int.Parse);

            //pembuatan wadah
            int tempMax = 0;
            int tempMin = 0;
            int temp = 0;

            for (int i = 0; i < arrDer1.Length; i++)
            {
                for (int j = 0; j < arrDer2.Length; j++)
                {
                    temp = arrDer1[i] + arrDer2[j];
                    if (temp > tempMax)
                    {
                        tempMax = temp;
                    }
                    if (temp < tempMax && temp < tempMin)
                    {
                        tempMin = temp;
                    }
                }
            }

            Console.WriteLine("Output Maximum : {0}", tempMax);
            Console.WriteLine("Output Minimum : {0}", tempMin); // Kurang output minimum
            Console.ReadKey();
        }
    }
}