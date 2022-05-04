using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal6
{
    public class Mini_MaxSUM
    {
        public Mini_MaxSUM()
        {
            //PEMBUATAN WADAH DULU
            int tempMax = 0;
            int tempMin = 0;

            //PEMASUKAN INPUTAN
            Console.Write("Input (pemisah dengan spasi): ");
            string input = Console.ReadLine();

            string[] strDeret = input.Split(' ');
            int[] arrDeret = Array.ConvertAll<string, int>(strDeret, int.Parse);

            Array.Sort(arrDeret);

            int panjang = arrDeret.Length - 1;
            tempMin = arrDeret[0] + arrDeret[1] + arrDeret[2] + arrDeret[3];
            tempMax = arrDeret[panjang - 3] + arrDeret[panjang - 2] + arrDeret[panjang - 1] + arrDeret[panjang];

            Console.WriteLine("Nilai max: {0}", tempMax);
            Console.WriteLine("Nilai min: {0}", tempMin);

            Console.ReadKey();

            
        }
    }
}