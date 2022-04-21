using System;

namespace LatihanSoal
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
                Console.WriteLine(" 1: Soal 01");
                Console.WriteLine(" 2: Soal 02");
                Console.WriteLine(" 3: Soal 03");
                Console.WriteLine(" 4: Soal 04");
                Console.WriteLine("99: Keluar");
                Console.Write("Pilihan :");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Dim1Soal1 solusi01 = new Dim1Soal1();
                        break;
                    case 2:
                        Dim1Soal2 solusi02 = new Dim1Soal2();
                        break;
                    case 3:
                        Dim1Soal3 solusi03 = new Dim1Soal3();
                        break;
                    case 4:
                        Dim1Soal4 solusi04 = new Dim1Soal4();
                        break;
                    case 99:
                        keluar = "Y";
                        break;
                    default:
                        break;
                }
                //Console.Write("Keluar [Y/T]: ");
                //keluar = Console.ReadLine();
            }
        }

        private static void Modulus()
        {
            Console.Write("Masukkan nilai: ");

            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai % 2 == 0)
            {
                Console.WriteLine("Genap");
            }
            else
            {
                Console.WriteLine("Ganjil");
            }
        }

        private static void Aritmatika()
        {
            // Increment
            Console.Write("Masukkan nilai: ");

            int nilai = Convert.ToInt32(Console.ReadLine());

            // Menampilan nilai
            Console.WriteLine("Nilai {0}", nilai);

            // Increment terlebih dahulu selanjutnya ditampilkan
            Console.WriteLine("++Nilai {0}", ++nilai);

            // Ditampilkan terlibih dahulu selanjutnya di increment

            Console.WriteLine("Nilai++ {0}", nilai++);

            // menambah nilai
            // nilai = nilai + 3;
            nilai += 3;
            Console.WriteLine("+=Nilai {0}", nilai);

            // mengurangi nilai
            // nilai = nilai - 5;
            nilai -= 5;
            Console.WriteLine("-=Nilai {0}", nilai);

            // nilai awal + mnjd -; dan sebaliknya.
            Console.WriteLine("-Nilai {0}", -nilai);

            Console.WriteLine("Press...");
            Console.ReadKey();
        }

        static void Perkenalan()
        {
            Console.WriteLine("=== PROGRAM KEREN ===");

            Console.Write("Tuliskan nama depan: ");
            string namaDepan = Console.ReadLine();

            Console.Write("Tuliskan nama belakang: ");
            string namaBelakang = Console.ReadLine();

            Console.WriteLine("Hi, {0} {1} selamat datang", namaDepan, namaBelakang);
            Console.WriteLine($"Hi, {namaDepan} {namaBelakang} selamat datang");
            Console.WriteLine("Hi, " + namaDepan + " selamat datang");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


    }
}
