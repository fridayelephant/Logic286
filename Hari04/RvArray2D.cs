using Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hari04
{
    public class RvArray2D
    {
        public RvArray2D()
        {
            Console.WriteLine("Array 2 Dimensi");
            Console.WriteLine("tanda | untuk baris dan , untuk kolom");
            
            // Memasukan inputan
            Console.Write("Masukan array 2D: ");
            string inputStr = Console.ReadLine();

            //Pembuatan array
            string[] strBaris = inputStr.Split('|');
            string[] strKolom = strBaris[0].Split(',');

            string[,] arrString = new string[strBaris.Length, strKolom.Length];

            for (int row = 0; row < strBaris.Length; row++)
            {
                for (int col = 0; col < strKolom.Length; col++)
                {
                    strKolom = strBaris[row].Split(',');
                    arrString[row, col] = strKolom[col];
                }
            }
            Tools.CetakArray2D(arrString);
            Console.ReadKey();
        }
    }
}