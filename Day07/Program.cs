using System;

namespace Day07
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
                Console.WriteLine(" 1: Parkir");
                Console.WriteLine(" 2: Pairs");
                Console.WriteLine(" 3: Ice Cream Parlor");
                Console.WriteLine(" 4: RD Sum");
                Console.WriteLine("99: Coba");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Parkir parkir = new Parkir();
                        break;
                    case 2:
                        Pairs pairs = new Pairs();
                        break;
                    case 3:
                        IceCreamPalor iceCreamPalor = new IceCreamPalor();
                        break;
                    case 4:
                        RDSum rDSum = new RDSum();
                        break;
                    case 98:
                        Coba coba = new Coba();
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
