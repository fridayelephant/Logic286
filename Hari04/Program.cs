using System;

namespace Hari04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latihan Soal Dimensi 1");
            string keluar = "T";
            while (keluar == "T")
            {
                Console.WriteLine("== Menu Utama ===");
                Console.WriteLine("Pilih Soal yang Ingin Dilihat");
                Console.WriteLine(" 1: RvArray1D");
                Console.WriteLine(" 2: RvArray2D");
                Console.WriteLine(" 3: List Single Value");
                Console.WriteLine(" 4: List Multi Value");
                Console.WriteLine(" 5: TimeConversion");
                Console.WriteLine(" 6: Kalendarrrrr");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        RvArray1D solusi01 = new RvArray1D();
                        break;
                    case 2:
                        RvArray2D solusi02 = new RvArray2D();
                        break;
                    case 3:
                        ListSingleValue solusi03 = new ListSingleValue();
                        break;
                    case 4:
                        ListMultiValue solusi04 = new ListMultiValue();
                        break;
                    case 5:
                        TimeConversion solusi05 = new TimeConversion();
                        break;
                    case 6:
                        CalendarHari04 solusi06 = new CalendarHari04();
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
