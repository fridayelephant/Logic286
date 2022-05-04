using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal6
{
    public class Rotasi
    {
        public Rotasi()
        {
            //Pemasukan inputan
            Console.Clear();
            Console.Write("Masukan deret angka (pemisah dengan spasi): ");
            string input = Console.ReadLine();
            
            Console.Write("Masukan banyak rotasi: ");
            int rotate = int.Parse(Console.ReadLine());

            // pembuatan array dan pemisahan deret
            string[] strInput = input.Split(' ');

            //proses rotasi
            for (int i=0; i<rotate; i++)
            {
                // temp adalah wadah untuk input str sementara yang dirotasi
                string temp = strInput[0];
                for (int j=0; j<strInput.Length; j++)
                {
                    if ( j == strInput.Length - 1)
                    {
                        break;
                    }
                    strInput[j] = strInput[j + 1];
                }

            }
            
            for (int j = 0; j < strInput.Length; j++)
                Console.Write(strInput[j] + "\t");

            Console.ReadKey();

        }
    }
}
