using System;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latihan Soal 3");
            string keluar = "T";
            while (keluar == "T")
            {
                Console.WriteLine("== Menu Utama ===");
                Console.WriteLine("Pilih Soal yang Ingin Dilihat");
                Console.WriteLine(" 1: Anagram");
                Console.WriteLine(" 2: Two-String");
                Console.WriteLine(" 3: Big Sorting");
                //Console.WriteLine(" 4: Caesar Cipher");
                //Console.WriteLine(" 3: Stair Case");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Anagram solusi01 = new Anagram();
                        break;
                    case 2:
                        Two_String two_String = new Two_String();
                        break;
                    case 3:
                        BigSorting bigSorting = new BigSorting();
                        break;
                        //case 4:
                        //    Caesar_Cipher solusi04 = new Caesar_Cipher();
                        break;
                    case 99:
                        keluar = "Y";
                        break;
                    default:
                        break;
                }
                Console.Write("Keluar [Y/T]: ");
                keluar = Console.ReadLine();
            }
        }
    }
}
