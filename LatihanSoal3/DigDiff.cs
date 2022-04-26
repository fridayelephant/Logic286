using Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal3
{
    public class DigDiff
    {
        public DigDiff()
        {
            //Pembuatan Array 2 dimensi
            //Inputan harus ada 2 separator. Contoh | utk baris dan , utk kolom
            //  11   2    4   
            //  4    5    6   
            //  10  8   -12
            Console.WriteLine("=== Diagonal ===");
            Console.WriteLine("tanda | utk baris dan , untuk kolom");
            Console.Write("Masukkan array 2 d :");
            string inputStr = Console.ReadLine();
            string[] strBaris = inputStr.Split('|');
            string[] strKolom = strBaris[0].Split(',');
            int sum = 0;

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

            // Diagonal Operation
            // Primari diagonal (diag kiri) = 11 + 5 -12 = 4
            // Secondary diagonal (diag kanan) = 4+5+1- = 19
            // Difference = |4-9| = 15

            int sumDataKiri = 0;
            Console.WriteLine("\nList Data Diagonal Kiri adalah: ");

            for (int row = 0; row <strBaris.Length; row++)
            {
                for (int col = 0; col <strKolom.Length; col++)
                {
                    //Diagonal Kiri
                    if (row == col)
                    {
                        Console.WriteLine(arrString[row, col]);
                        int bilDiagonal = int.Parse(arrString[row, col]);
                        sumDataKiri += bilDiagonal;
                    }
                }
            }

            Console.Write($"Sum Data: {sumDataKiri}");


            Console.WriteLine("\nList Data Diagonal Kanan adalah: ");
            int sumDataKanan = 0;
            for (int row = 0; row <strBaris.Length; row++)
            {
                for (int col = 0; col < strKolom.Length; col++)
                {
                    //DIagonal Kanan
                    if (row + col == strBaris.Length-1)
                    {
                        Console.WriteLine(arrString[row, col]);
                        int bilDiagonal = int.Parse(arrString[row, col]);
                        sumDataKanan += bilDiagonal;
                    }
                }
            }
            Console.WriteLine($"Sum Data : {sumDataKanan}");
            Console.WriteLine($"\nDifference: |{sumDataKiri}| - |{sumDataKanan}| = {Math.Abs(sumDataKiri - sumDataKanan)}");
            
            Console.WriteLine("Press any Key to Continue....");
            Console.ReadKey();

        }
    }
}
