using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal4
{
    public class SortingAlphabet
    {
        public SortingAlphabet()
        {
            Console.Clear();
            ////Cara 1
            //Console.Write("Masukan Input: ");
            //string Alphabet = Console.ReadLine();

            //char[] temp = Alphabet.ToCharArray();

            //Array.Sort(temp);
            //Console.WriteLine(temp);
            //Console.ReadKey();

            //Cara2
            Console.Write("Masukan deret huruf (tanpa spasi): ");
            string deretHuruf = Console.ReadLine();

            int[] intHuruf = new int[deretHuruf.Length];
            string[] strHuruf = new string[intHuruf.Length];

            //convert string ke ASCII
            for (int i = 0; i < deretHuruf.Length; i++)
                intHuruf[i] = Convert.ToInt32(deretHuruf[i]);


            // Sorting array interger ASCII tadi
            for (int i = 1; i < intHuruf.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)  // looping buat sorting array intHuruf[j]
                {
                    if (intHuruf[j+1] < (intHuruf[j]))
                    {
                        int temp = intHuruf[j + 1];         // implementasinya  1 2 3 4 5 ---> _ 2 3 4 5 (dimana temp = {1}
                        intHuruf[j + 1] = intHuruf[j];
                        intHuruf[j] = temp;
                    }
                }
            }

            //Convert data ASCII yang telah disorting menjadi string 
            for (int i = 0; i < intHuruf.Length; i++)
                strHuruf[i] = Convert.ToChar(intHuruf[i]).ToString();

            foreach (string str in strHuruf)
            {
                Console.Write(str);
            }

            Console.ReadKey();
        }
    }
}
