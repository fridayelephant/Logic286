using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    public class Soal05
    {
        public Soal05()
        {
            Console.Write("Masukan size pola: ");
            int nPola = int.Parse(Console.ReadLine());

            for (int i = 0; i < nPola; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    if (j % 2 != 0)
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


