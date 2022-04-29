using System;

namespace Day05
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
                Console.WriteLine(" 1: VeryBigSum");
                Console.WriteLine(" 2: Hackerrank!String");
                Console.WriteLine(" 3: Gemstone");
                //Console.WriteLine(" 3: Stair Case");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        VeryBigSum solusi01 = new VeryBigSum();
                        break;
                    case 2:
                        HackerrankInString solusi02 = new HackerrankInString();
                        break;
                    case 3:
                        Gemstone solusi03 = new Gemstone();
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
