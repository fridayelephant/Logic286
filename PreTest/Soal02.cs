using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    public class Soal02
    {
        public Soal02()
        {
            Console.WriteLine("Temukan kata dalam Kalimat");
            Console.WriteLine("Insert code : ");
            string strWord1 = Console.ReadLine();

            Console.WriteLine("Insert word : ");
            string strWord2 = Console.ReadLine();

            char[] charWord1 = strWord1.ToCharArray();
            char[] charWord2 = strWord2.ToCharArray();

            int count = 0;

            for (int i = 0; i < charWord1.Length; i++)
            {
                for (int j = 0; j < charWord2.Length; j++)
                {
                    if (charWord1[i] == (charWord2[j]))
                    {
                        count++;
                        continue;
                    }
                }
            }

            if (count == charWord1.Length)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.ReadKey();
        }
    }
}
