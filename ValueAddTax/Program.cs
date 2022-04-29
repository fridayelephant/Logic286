using System;

namespace LatihanSoal5
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
                Console.WriteLine(" 1: Value Add Tax");
                Console.WriteLine(" 2: Progresive VAT");
                Console.WriteLine(" 3: Library");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        ValueAddTax valueAddTax = new ValueAddTax();
                        break;
                    case 2:
                        ProgTax progTax = new ProgTax();
                        break;
                    case 3:
                        Library library = new Library();
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

