using System;

namespace LatihanSoal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latihan Soal Dimensi 2");
            string keluar = "T";
            while (keluar == "T")
            {
                Console.WriteLine("== Menu Utama ===");
                Console.WriteLine("Pilih Soal yang Ingin Dilihat");
                Console.WriteLine(" 1: Soal Dim2 no.7-10 ");
                Console.WriteLine(" 2: Solve Me First ");
                Console.WriteLine(" 3: Simple Array Sum ");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine(" === Pilih Soal yang ingin dicoba ===");
                        Console.WriteLine(" 1: Soal 07");
                        Console.WriteLine(" 2: Soal 08");
                        Console.WriteLine(" 3: Soal 09");
                        Console.WriteLine(" 4: Soal 10");
                        Console.WriteLine("99: Keluar");
                        Console.Write("Pilihan :");
                        int day2 = int.Parse(Console.ReadLine());
                        switch (day2)
                        {
                            case 1:
                                Dim2Soal7 solusi01 = new Dim2Soal7();
                                break;
                            case 2:
                                Dim2Soal8 solusi02 = new Dim2Soal8();
                                break;
                            case 3:
                                Dim2Soal9 solusi03 = new Dim2Soal9();
                                break;
                            case 4:
                                Dim2Soal10 solusi04 = new Dim2Soal10();
                                break;
                            case 99:
                                keluar = "Y";
                                break;
                            default:
                                break;
                        }
                        break;
                        Console.Write("Keluar [Y/T]: ");
                    case 2:
                        SolveMe solusi05 = new SolveMe();
                        break;
                    case 3:
                        SimpArrSum solusi06 = new SimpArrSum();
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
