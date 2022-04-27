using System;
using System.Collections.Generic;
using System.Text;

namespace Day05
{
    public class HackerrankInString
    {
        public HackerrankInString()
        {
            Console.Clear();
            Console.WriteLine("=== Hackerrank in String! ===");

            Console.Write("Kalimat : ");
            string kalimat = Console.ReadLine();

            int count = 0;

            int posisiH = kalimat.IndexOf('h');
            if (posisiH > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiH + 1);
            }
            int posisiA = kalimat.IndexOf('a');
            if (posisiA > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiA + 1);
            }
            int posisiC = kalimat.IndexOf('c');
            if (posisiC > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiC + 1);
            }
            int posisiK = kalimat.IndexOf('k');
            if (posisiK > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiK + 1);
            }
            int posisiE = kalimat.IndexOf('e');
            if (posisiE > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiE + 1);
            }
            int posisiR = kalimat.IndexOf('r');
            if (posisiR > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiR + 1);
            }
            int posisiRR = kalimat.IndexOf('r');
            if (posisiRR > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiRR + 1);
            }
            int posisiAA = kalimat.IndexOf('a');
            if (posisiAA > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiAA + 1);
            }
            int posisiN = kalimat.IndexOf('n');
            if (posisiN > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiN + 1);
            }
            int posisiKK = kalimat.IndexOf('k');
            if (posisiKK > -1)
            {
                count++;
                kalimat = kalimat.Substring(posisiKK + 1);
            }

            if (count == 10)
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");
            Console.WriteLine("Press...");
            Console.ReadKey();


        }
    }
}
