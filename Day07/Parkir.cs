using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    public class Parkir
    {
        public Parkir()
        {
            Console.WriteLine("Masukan jam masuk anda: [dd/mm/yyy HH:mm:ss] ");
            DateTime awal = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Masukan jam keluar anda: [dd/mm/yyy HH:mm:ss] ");
            DateTime akhir = Convert.ToDateTime(Console.ReadLine());

            // Selisih
            TimeSpan selisih = akhir.Subtract(awal);

            Console.WriteLine("durasi: {0}", (selisih).TotalSeconds);

            // Parameter Hari
            int waktuHari = Convert.ToInt32(selisih.Days);
            int waktuJam = Convert.ToInt32(selisih.Hours);
            int waktuMenit = Convert.ToInt32(selisih.Minutes);
            int waktuDetik = Convert.ToInt32(selisih.Seconds);

            int harga1 = 0;
            int harga2 = 0;
            int harga3 = 0;

            if (waktuHari > 0)
            {
                harga1 = 20000 * waktuHari;
            }

            for (int i = 0; i < waktuJam; i++)
            {
                harga2 = harga2;
                if (i < 7)
                {
                    harga2 += 2000;
                }
                else if (i >= 7 && i < 12)
                {
                    harga2 += 1500;
                }
                else if (i >= 12)
                {
                    harga2 += 1000;
                }
            }

            if (waktuMenit > 0 && waktuJam < 7 && waktuHari < 1)
            {
                harga3 = 2000;
            }
            else
            {
                harga3 = 1000;
            }

            if (waktuDetik > 0 && waktuJam < 7 && waktuHari < 1)
            {
                harga3 = 2000;
            }
            else
            {
                harga3 = 1000;
            }

            int hargaTotal = harga1 + harga2 + harga3;

            Console.WriteLine("Selisihnya = {0}", selisih);
            Console.WriteLine("Harinya = {0}", waktuHari);
            Console.WriteLine("Jamnya = {0}", waktuJam);
            Console.WriteLine("Menitnya = {0}", waktuMenit);
            Console.WriteLine("Detiknya = {0}", waktuDetik);
            Console.WriteLine("harga 1 = {0}", harga1);
            Console.WriteLine("harga 2 = {0}", harga2);
            Console.WriteLine("harga 3 = {0}", harga3);
            Console.WriteLine("harga = {0}", hargaTotal);
            Console.ReadKey();
        }
    }
}
