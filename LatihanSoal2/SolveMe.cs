using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal2
{
    public class SolveMe
    {
        public SolveMe()
        {
            Console.Clear();
            Console.WriteLine("=== Solve Me First ===");

            Console.Write("Masukan angka pertama (a) : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Masukan angka kedua(b) : ");
            int n2 = int.Parse(Console.ReadLine());

            //masukan input a+b = hasil
            int hasil = n1 + n2;
            Console.WriteLine("=== === === === === ===");
            Console.WriteLine("Hasil: {0}", hasil);
            Console.WriteLine("Penjumlahan kedua bilangan a dan b adalah : {0} + {1} = {2}", n1, n2, hasil);

            Console.ReadKey();
        }
    }
}
