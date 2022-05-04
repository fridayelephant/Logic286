using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal6
{
    public class Polindrom
    {
        public Polindrom()
        {
            Console.WriteLine("=== Polindrom Program ===");
            Console.Write("Insert word : ");
            string strWord = Console.ReadLine();

            char[] charWord = strWord.ToCharArray();

            int count = 0;

            for (int i = 0; i < charWord.Length; i++)
            {
                if (charWord[i] == (charWord[charWord.Length-1]))
                {
                    count++;
                }
            }

            if (count == charWord.Length)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.ReadKey();
        }
    }
}
