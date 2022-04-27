using System;
using System.Collections.Generic;
using System.Text;

namespace CHALLANGETEST1
{
    public class Challange03
    {
        public Challange03()
        {
            Console.WriteLine("Input: ");
            string strInput = Console.ReadLine();
            string[] arrString = strInput.Split(' ');
            int[] arrInt = Array.ConvertAll<string, int>(arrString, int.Parse);

            int jumlah = 0;
            int tempMax = 0;
            int tempMin = 0;

            for (int i = 0; i < arrInt.Length; i++)
            {
                for (int j = 0; j < arrInt.Length; j++)
                {
                    // pengecualian i
                    if (i != j)
                    {
                        jumlah += int.Parse(arrString[j]);
                    }
                }

                if (i == 0)
                { 
                    tempMax = jumlah;
                    tempMin = jumlah;
                }

                else
                {
                    if (tempMax < jumlah)
                        tempMax = jumlah;
                    if (tempMin > jumlah)
                        tempMin = jumlah;
                }
            }

            Console.WriteLine($"Minimal = {tempMin} & Maximal = {tempMax}");
            Console.WriteLine("press...");
            Console.ReadKey();
        }
    }
}
