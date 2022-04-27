using System;
using System.Collections.Generic;
using System.Text;

namespace Day06
{
    public class Two_String
    {
        public Two_String()
        {
            Console.Clear();
            Console.WriteLine("=== GEMSTONE===");

            bool common = false;

            Console.Write("Kata 1: ");
            string kata1 = Console.ReadLine();

            Console.Write("Kata 2: ");
            string kata2 = Console.ReadLine();

            for (int i = 0; i < kata1.Length; i++)
            {
                for (int j = 0; j < kata2.Length; j++)
                {
                    if (kata1[i] == kata2[j])
                        common = true;
                }
            }

            Console.WriteLine(common);
        }
    }
}
