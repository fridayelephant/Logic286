using System;

namespace LatihanSoal6
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
                Console.WriteLine(" 1: Mini-Max Sum");
                Console.WriteLine(" 2: Rotasi");
                Console.WriteLine(" 3: Polindrom");
                Console.WriteLine(" 4: Maximum Buying");
                Console.WriteLine(" 98: Coba");
                //Console.WriteLine(" 3: Stair Case");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Mini_MaxSUM solusi01 = new Mini_MaxSUM();
                        break;
                    case 2:
                        Rotasi solusi02 = new Rotasi();
                        break;
                    case 3:
                        Polindrom solusi03 = new Polindrom();
                        break;
                    case 4:
                        MaxBuying solusi04 = new MaxBuying();
                        break;
                    case 98:
                        Coba solusi98 = new Coba();
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
