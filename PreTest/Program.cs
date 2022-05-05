using System;

namespace PreTest
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
                Console.WriteLine(" 1: Soal 1()");
                Console.WriteLine(" 2: Soal 2()");
                Console.WriteLine(" 3: Soal 3()");
                Console.WriteLine(" 4: Soal 4()");
                Console.WriteLine(" 5: Soal 5()");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Soal01 solusi01 = new Soal01();
                        break;
                    case 2:
                        Soal02 solusi02 = new Soal02();
                        break;
                    case 3:
                        Soal03 solusi03 = new Soal03();
                        break;
                    case 4:
                        Soal04 solusi04 = new Soal04();
                        break;
                    case 5:
                        Soal05 solusi05 = new Soal05();
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
