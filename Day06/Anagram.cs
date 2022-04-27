using System;
using System.Collections.Generic;
using System.Text;

namespace Day06
{
    public class Anagram
    {
        public Anagram()
        {
            Console.WriteLine("=== Anagram ===");
            Console.Clear();

            //membuat wadah kosong temporary
            string tmp1 = "";
            string tmp2 = "";

            Console.Write("Input masukan pertama");
            string str1 = Console.ReadLine();
            
            Console.Write("Input masukan pertama");
            string str2 = Console.ReadLine();

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                    if (str1[i] == str2[j])
                    {
                        tmp1 += str1[i];
                        tmp2 += str2[i];
                        str1 = str1.Remove(i, 1);
                        str2 = str2.Remove(j, 1);
                        i--;
                        break;
                    }
            }
            Console.WriteLine($"kata1: {str1} \nkata2: {str2} \ntemp1: {tmp1} \ntemp2: {tmp2}");
            Console.WriteLine(str1.Length + str2.Length);
            Console.ReadKey();

        }
    }
}
