using System;

namespace CHALLANGETEST1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latihan Soal 3");
            string keluar = "T";
            while (keluar == "T")
            {
                Console.WriteLine("== Menu Utama ===");
                Console.WriteLine("Pilih Soal yang Ingin Dilihat");
                Console.WriteLine(" 1: Challange Test ke-1");
                Console.WriteLine(" 2: Challange Test ke-2");
                Console.WriteLine(" 3: Challange Test ke-3");
                Console.WriteLine(" 4: Caesar Cipher");
                //Console.WriteLine(" 3: Stair Case");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Challange01 solusi01 = new Challange01();
                        break;
                    case 2:
                        Challange02 solusi02 = new Challange02();
                        break;
                    case 3:
                        Challange03 solusi03 = new Challange03();
                        break;
                    case 4:
                        Caesar_Cipher solusi04 = new Caesar_Cipher();
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
