using System;
using System.Collections.Generic;
using System.Text;

namespace Day05
{
    public class VeryBigSum
    {
        public VeryBigSum()
        {
            //KONSEP AWAL
            //               (1) 
            // Angka 0 =  **1009
            // Angka 1 =  *10000
            // Angka 3 =  100001
            // ------------------ +
            //            111010


            Console.WriteLine("=== Very Big Sum ===");
            string[] arrString = Console.ReadLine().Split(' '); // Pemisah tiap angka
            int panjang = 0;    // Wadah

            for (int i = 0; i < arrString.Length; i++) //jika semua nilai sama panjang length-nya
            {
                if (panjang < arrString[i].Length)
                    panjang = arrString[i].Length;
            }

            for (int i = 0; i < arrString.Length; i++)  //jika panjang tiap nilai beda maka disamakan panjangnya
            {
                if (panjang > arrString[i].Length)
                    arrString[i] = new string('0', panjang - arrString[i].Length) + arrString[i];   //kekurangan panjang diisi dengan angka "0" dimulai dari kanan
            }

            string result = "";
            int jumlah = 0;
            int sisa = 0;
            for (int pos = panjang - 1; pos >= 0; pos--)
            {
                jumlah = sisa;
                sisa = 0;
                for (int i = 0; 1 < arrString.Length; i++)
                    jumlah += int.Parse(arrString[i].Substring(pos, 1));
                if (jumlah > 9)
                {
                    string jmlStr = jumlah.ToString();
                    result = jmlStr.Substring(jmlStr.Length - 1, 1) + result;
                    sisa = int.Parse(jmlStr.Substring(0, jmlStr.Length - 1));
                }
                else
                    result = jumlah.ToString() + result;
            }
            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();
        }
    }
}
