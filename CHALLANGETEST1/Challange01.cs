using Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace CHALLANGETEST1
{
    public class Challange01
    {
        public Challange01()
        {
            // Tugas bikin dimensi array row 5 col 4
            // dibikin input string pemisah pakai "|" utk row dan "," utk col
            // buat penjumlahan indeks [2,3] dan [1,2] = dibuat hasilnya = 10
            
            Console.WriteLine("=== Challange ke-2");
            Console.WriteLine(" tanda | untuk baris dan , untuk kolom");
            Console.Write("Masukan deret angka yang ingin dibuat array 2D: ");
            string inputStr = Console.ReadLine();

            //define parameter dan wadah
            string[] strBaris = inputStr.Split('|');  //membuat split utk row berdasarkan "|" yang ada pada string inputStr
            string[] strKolom = strBaris[0].Split(',');  //membuat split utk kolom berdasarkan "," yang ada pada string strBaris
            int sum = 0; //wadah untuk hasil penjumlahan

            //Membuat array dengan dimensi sebanyak hasil inputan row(strBaris) dan kolom (strKolom)
            string[,] arrString = new string[strBaris.Length, strKolom.Length];

            //pembuatan looping array
            for (int row = 0; row < strBaris.Length; row++)
            {
                for (int col = 0; col < strKolom.Length; col++)
                {
                    strKolom = strBaris[row].Split(',');    //mencacah tiap strBaris ditiap baris (row) menjadi inputan-inputan pada tiap kolom dengan tanda ","
                    arrString[row, col] = strKolom[col];    //hasil angka disimpan kedalam strKolo[col] tadi dan dimasukan ke wadah array "arrString[row, col]"
                }
            }
            Tools.CetakArray2D(arrString);

            //Pengambilan bilangan di [row,col] tertentu dan penjumlahan row tertentu
            Console.WriteLine("\n List Angka yang diambil [2,3] dan [1,2]");

            //karena strBaris masih dibaca ada 5 variabel ("1" "," "2" "," "3")
            //digunakan split agar isiKolom dibaca 3 variabel  ("1"  "2"  "3")
            string[] isiKolom = strBaris[0].Split(',');

            // pemisahan array int dengan strBaris = 3 (dipisahkan oleh "|")
            // strBaris[0].Split(',') membaca strBaris ke-1 dipisahkan menjadi ("1"  "2"  "3")
            // membuat strBaris[0].Split(',').Length menjadi = 3
            int[,] arrInt = new int[strBaris.Length, strBaris[0].Split(',').Length];
            


       

        }
    }
}
