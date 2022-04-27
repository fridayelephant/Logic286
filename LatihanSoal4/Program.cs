using System;

namespace LatihanSoal4
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
                Console.WriteLine(" 1: Finding The Median");
                Console.WriteLine(" 2: Sorting The Alphabet");
                Console.WriteLine(" 3: Missing Number");
                Console.WriteLine(" 4: Sherlock and Arrays");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        FindingTheMedian solusi01 = new FindingTheMedian();
                        break;
                    case 2:
                        SortingAlphabet solusi02 = new SortingAlphabet();
                        break;
                    case 3:
                        MissingNumber solusi03 = new MissingNumber();
                        break; 
                    case 4:
                        SherlockArray solusi04 = new SherlockArray();
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
