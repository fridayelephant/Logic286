using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal6
{
    public class Coba
    {
        public  Coba()
        {
            Console.Clear();

            long jumlahB = 0; ;
            Console.Write("Masukan Deret Angka: ");
            string input = Console.ReadLine();
            string[] deretStr = input.Split(' ');
            long[] deretLong = Array.ConvertAll<string, long>(deretStr, long.Parse);

            for (int i = 0; i < deretLong.Length; i++)
            {
                jumlahB += deretLong[i];
                Console.WriteLine("Sekarang jumlahnya = {0}", jumlahB);
            }

            Console.WriteLine("inputan deretnya = {0}", input);
            Console.WriteLine("panjang deretnya = {0}", deretStr.Length);
            Console.Write("Total jumlahB = {0}", jumlahB);

            Console.WriteLine("\nPress...");
            Console.ReadLine();
        }
    }
}
