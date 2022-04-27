using System;
using System.Collections.Generic;
using System.Text;

namespace Day06
{
    public class BigSorting
    {
        public BigSorting()     //method penginput
        {
            //Input Variabel
            Console.WriteLine("Masukan banyak angka yang dibandingkan:  ");
            var n = int.Parse(Console.ReadLine());     // Step 01: Karena saya pusing jadi pakai var, dan di convert ke interger
            var arr = new string[n];                   // wadah untuk array string baru  sebanyak "n"
            for (var arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();            //untuk tiap looping array ke-i direkam ke wadah "arr"
                Console.WriteLine($"isi arr adalah : {arr[arr_i]}");
            }

            Array.Sort(arr, new NumericStringComparer());
            Console.WriteLine(String.Join("\n", arr));  // nantinya string semua digabung, namun dipisah dalam bentuk \n (pindah baris)
        }
    }

    public class NumericStringComparer : IComparer<string>  //pakai fungsi IComparer dengan tipe string
    {
        public int Compare(string x, string y)      //method pengompare
        {
            // Compare x and y as numbers without leading zeroes.
            if (x == null)
            {
                return (y == null) ? 0 : -1;
            }
            if (y == null)
            {
                return 1;
            }
            if (x.Length < y.Length)
            {
                return -1;
            }
            if (y.Length < x.Length)
            {
                return 1;
            }
            return x.CompareTo(y);
        }
    }

}
