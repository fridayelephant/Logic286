using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal5
{
    public class Library
    {
        public Library()
        {
            Console.Clear();
            Console.WriteLine("=== Library Program ===");

            Console.WriteLine("Masukan tanggal peminjaman   : [dd/mm/yyy HH:mm:ss]");
            DateTime tglPinjam = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Masukan tanggal pengembalian : [dd/mm/yyy HH:mm:ss]");
            DateTime tglKembali = Convert.ToDateTime(Console.ReadLine());

            TimeSpan selisih = tglKembali.Subtract(tglPinjam);

            int jmlHari= Convert.ToInt32(selisih.Days);

            int overDue1 = 0;
            int overDue2 = 0;
            int overDue3 = 0;

            
            //History Book
            if (jmlHari > 3)
                overDue1 = (jmlHari - 3) * 250;

            //Biology
            if (jmlHari > 4)
                overDue2 = (jmlHari - 4) * 250;

            //Math
            if (jmlHari > 5)
                overDue3 = (jmlHari - 5) * 250;

            int totalDue = overDue1 + overDue2 + overDue3;


            Console.WriteLine("Durasi Peminjaman adalah = {0}", jmlHari);
            Console.WriteLine("maka denda = {0}", totalDue);
            Console.ReadKey();



        }
    }
}
