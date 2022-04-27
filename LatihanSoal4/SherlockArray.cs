using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal4
{
    public class SherlockArray
    {
        public SherlockArray()
        {
            Console.Clear();
            Console.WriteLine("Sherlock: 'Give the code please, Watson!' ");
            Console.WriteLine("Watson: 'hhhh...sherlock need the code to solve again' ");
            Console.WriteLine("Watson: 'Sir, Can you give him the code to solve,please?' ");
            Console.Write("Enter the code to solve (use space for each new number enter): ");
            string strderet = (Console.ReadLine());

            string[] arrderet = strderet.Split(' ');

            int[] intArrderet = Array.ConvertAll<string, int>(arrderet, int.Parse);

            int kiri = 0;
            int kanan = 0;
            bool status = false;

            //11411
            for (int i = 0; i < intArrderet.Length; i++)
            {
                kiri = 0; //untuk mengembalikan nilai setelah dilooping
                kanan = 0;

                for (int j = 0; j < intArrderet.Length; j++)
                {
                    if (j < i)
                        kiri += intArrderet[j];
                    if (j > i)
                        kanan += intArrderet[j];
                }

                //validasi kondisi boolean
                if (kanan == kiri)
                { 
                    status = true;
                    break;
                }

            }

            Console.WriteLine(status);
            Console.ReadKey();
        }
    }
}
