using System;
using System.Collections.Generic;
using System.Text;

namespace Hari04
{
    public class CalendarHari04
    {
        public CalendarHari04()
        {
            //Masukan Input
            Console.WriteLine("=== Check Status ===");
            Console.WriteLine("Masukan Input: ");
            string Kalendarr = Console.ReadLine().ToUpper();

            //Pemisah Inputan
            string strTahun = Kalendarr.Substring(0, 2);
            string strBulan = Kalendarr.Substring(2, 1);
            string strDivisi = Kalendarr.Substring(3, 2);
            string strKode = Kalendarr.Substring(5, 3);

            //Convert Parameter Str ke Int (Karena nantinya ada penjumlahan)
            int intTahun = int.Parse(strTahun);
            int inValid = 0;
            string Div = null;
            string Bul = null;
            //Test Inputan Substring
            //Console.WriteLine("Maka hasilnya: {0}", inTahun);
            //Console.WriteLine("Maka hasilnya: {0}", inBulan);
            //Console.WriteLine("Maka hasilnya: {0}", inDivisi);
            //Console.WriteLine("Maka hasilnya: {0}", inKode);


            //Validasi Inputan Length
            if (strTahun.Length == 2 && strBulan.Length == 1 && strDivisi.Length == 2 && strKode.Length == 3 && inValid == 0)
            {
                //Range Tahun
                if (intTahun <= 21)
                {
                    intTahun = intTahun + 2000;
                    //Console.WriteLine("Tahun {0}", intTahun);
                }

                else if (intTahun >= 90 && intTahun <= 99)
                {
                    intTahun = intTahun + 1900;
                    //Console.WriteLine("Tahun {0}", intTahun);
                }
                else
                    inValid = 1;

                //Range Bulan
                if (strBulan == "A")
                    Bul = "Jan";
                else if (strBulan == "B")
                    Bul = "Feb";
                else if (strBulan == "C")
                    Bul = "Mar";
                else if (strBulan == "D")
                    Bul = "Apr";
                else if (strBulan == "E")
                    Bul = "Mei";
                else if (strBulan == "F")
                    Bul = "Jun";
                else if (strBulan == "G")
                    Bul = "Jul";
                else if (strBulan == "H")
                    Bul = "Aug";
                else if (strBulan == "I")
                    Bul = "Sept";
                else if (strBulan == "J")
                    Bul = "Okt";
                else if (strBulan == "K")
                    Bul = "Nov";
                else if (strBulan == "L")
                    Bul = "Des";
                else
                    inValid = 1;

                //Range Divisi
                if (strDivisi == "01")
                    Div = "Acc";
                else if (strDivisi == "02")
                    Div = "Finance";
                else if (strDivisi == "03")
                    Div = "HRD";
                else if (strDivisi == "04")
                    Div = "GA";
                else if (strDivisi == "05")
                    Div = "IT";
                else if (strDivisi == "06")
                    Div = "Divisi Audit";
                else
                    inValid = 1;
            }

            if (inValid == 0)
                Console.WriteLine($"Tahun: {intTahun} \nBulan: {Bul} \nDivisi:{Div} \nNoSeri {strKode}");
            else
            { 
            Console.WriteLine("Input Tidak Valid");
            }

            Console.ReadKey();

        }
    }
}
