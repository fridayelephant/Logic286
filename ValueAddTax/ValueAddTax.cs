using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal5
{
    public class ValueAddTax
    {
        public ValueAddTax()
        {
            Console.Clear();
            Console.WriteLine("=== Value Add Tax Program ===");

            Console.Write("Masukan nilai VAT: ");
            double nilaiVAT = Convert.ToDouble(Console.ReadLine());

            double nilaiOri = 0;
            double nilaiTax = nilaiVAT;

            nilaiTax /= 1.1;
            nilaiTax -= nilaiVAT;
            nilaiOri = Math.Round(nilaiVAT - nilaiTax, 2);

            Console.WriteLine($"Nilai Awal adalah : {nilaiOri}");
            Console.WriteLine($"Nilai Tax adalah : {nilaiTax}");
            Console.WriteLine($"Nilai VAT adalah : {nilaiVAT}");

            Console.ReadKey();
        }
    }
}
