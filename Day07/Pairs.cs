using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    public class Pairs
    {
        public Pairs()
        {
            Console.WriteLine("Masukan Input: ");
            string strderet = (Console.ReadLine());
            string[] arrderet = strderet.Split(' ');
            int[] intArrderet = Array.ConvertAll<string, int>(arrderet, int.Parse);


            Console.Write("Masukan target: ");
            int target = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < intArrderet.Length; i++)
            {
             
                for (int j = 0; j < intArrderet.Length; j++)
                {
                    if (intArrderet[i] - intArrderet[j] == target)
                        count++; 
                }
            }

            Console.WriteLine("Banyaknya pasangan yang didapat: {0}", count);
            Console.ReadKey();
        }
    }
}
