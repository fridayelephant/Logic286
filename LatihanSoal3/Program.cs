using System;

namespace LatihanSoal3
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
                Console.WriteLine(" 1: Diagonal Difference");
                Console.WriteLine(" 2: Plus Minus");
                Console.WriteLine(" 3: Stair Case");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        DigDiff solusi01 = new DigDiff();
                        break;
                    case 2:
                        PlusMinus solusi02 = new PlusMinus();
                        break;
                    case 3:
                        StairCase solusi03 = new StairCase();
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
