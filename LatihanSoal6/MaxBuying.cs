using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal6
{
    public class MaxBuying
    {
        public MaxBuying()
        {
            Console.WriteLine("=== Maximum Buying ===");

            Console.Write("Masukan jumlah uang: ");
            int intUang = int.Parse(Console.ReadLine());

            //pemasukan harga
            //burger
            Console.Write("Masukan harga burger: ");
            string[] priceBurger = Console.ReadLine().Split();

            int[] arrBurger = Array.ConvertAll<string, int>(priceBurger, int.Parse);
            //kentang
            Console.Write("Masukan harga kentang: ");
            string[] pricePotato = Console.ReadLine().Split();

            int[] arrPotato = Array.ConvertAll<string, int>(pricePotato, int.Parse);

            //pembuatan wadah
            int tempMax = 0;
            int temp = 0;

            for (int i = 0; i < arrBurger.Length; i++)
            {
                for (int j = 0; j < arrPotato.Length; j++)
                {
                    if (intUang >= arrBurger[i] + arrPotato[j])
                    {
                        temp = arrBurger[i] + arrPotato[j];
                    }
                    if (tempMax < temp)
                    {
                        tempMax = temp;
                    }
                }

                if (tempMax < temp)
                {
                    tempMax = temp;
                }
            }

            Console.Write(tempMax);
            Console.ReadKey();
        }
    }
}

