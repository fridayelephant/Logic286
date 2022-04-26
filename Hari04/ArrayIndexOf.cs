using System;
using System.Collections.Generic;
using System.Text;

namespace Hari04
{
    public class ArrayIndexOf
    {
        public ArrayIndexOf()
        {
            string[] namaBulan = new string[] {"Jan","Feb","Mar","Apr","Mei","Jun","Jul","Aug","Sept","Okt","Nov","Des"};
            string kodeBulan = "ABCDEFGHIJKL";

            Console.Write("Masukan kode bulan [A-L]: ");
            string bln = Console.ReadLine().ToUpper();
            int index = kodeBulan.IndexOf(bln);

            if (index != -1)
                Console.WriteLine("Out of Range!");
            else
                Console.WriteLine($"Index Kode Bulan {bln}: {kodeBulan.IndexOf(bln)}  dan Nama Bulan: {namaBulan[index]}");

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadKey();
            //}
        }
    }
}
