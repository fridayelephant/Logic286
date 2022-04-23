using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal2
{
    public class SimpArrSum
    {
        public SimpArrSum()
        {
            //tampilan awal program
            Console.Clear();
            Console.WriteLine("=== Simple Array SUM ===");

            //define parameter
            int[] a = new int[100];
            int i, n, sum = 0;

            //penentuan size array
            Console.WriteLine();
            Console.Write("Masukan Size Array: ");
            n = Convert.ToInt32(Console.ReadLine());

            //penentuan nilai yang ingin di input
            Console.Write("Silahkan Input {0} Angka yang diinginkan (dimulai dari angka ke-0):\n", n);
            
            //looping dengan range inputan "n", dimana "a[i]" adalah wadah array hasil looping   
            for (i = 0; i < n; i++)
            {
                Console.Write("Angka ke - {0} : ", i+1);  // "i+1" dikarenakan angka array sebenarnya dimulai dari "0"
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //sum merupakan wadah bilangan yang ditotal dari looping wadah "a[]"
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.Write("Jumlah dari semua angka yang di input adalah: {0}\n\n", sum);
        }
    }
}
