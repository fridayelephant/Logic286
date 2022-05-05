using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    public class Soal03
    {
        public Soal03()
        {
            //Console.Write("Masukan Input: ");
            //string strWord = Console.ReadLine();

            //char[] charWord = strWord.ToCharArray();

            //Array.Sort(charWord);
            //Console.WriteLine(charWord);
            //Console.ReadKey();
            char temp;

            Console.WriteLine("Masukan kalimat : ");
            string myStr = Console.ReadLine();

            string str = myStr.ToLower();
            char[] charstr = str.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(charstr); //aagmtu  
            Console.ReadLine();
        }
    }
}

