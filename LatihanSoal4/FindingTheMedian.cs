using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal4
{
    public class FindingTheMedian
    {
        public FindingTheMedian()
        {
            /////////////////
            ///////Cara 1////
            /////////////////
            //Console.Write("Masukan deret angka(pemisah angka dengan spasi): ");
            //string strDeret = (Console.ReadLine());

            //string[] arrDeret = strDeret.Split(' ');

            //int[] intDeret = new int[arrDeret.Length];
            //string[] sortDeret = new string[intDeret.Length];

            ////convert string ke ASCII
            //for (int i = 0; i < arrDeret.Length; i++)
            //    intDeret[i] = Convert.ToInt32(arrDeret[i]);


            //// Sorting array interger ASCII tadi
            //for (int i = 1; i < intDeret.Length; i++)
            //{
            //    for (int j = i - 1; j >= 0; j--)  // looping buat sorting array
            //    {
            //        if (intDeret[j + 1] < (intDeret[j]))
            //        {
            //            int tempo = intDeret[j + 1];         // implementasinya  1 2 3 4 5 ---> _ 2 3 4 5 (dimana temp = {1}
            //            intDeret[j + 1] = intDeret[j];
            //            intDeret[j] = tempo;
            //        }
            //    }
            //}

            ////Convert data ASCII yang telah disorting menjadi string 
            //for (int i = 0; i < intDeret.Length; i++)
            //    sortDeret[i] = Convert.ToChar(intDeret[i]).ToString();

            //foreach (string str in sortDeret)
            //{
            //    Console.Write(str);
            //}

            //Console.WriteLine(sortDeret);



            ///////////////
            /////Cara 2////         kEKURANGAN, UNTUK ANGKA 2 DIGIT DAN 1 DIGIT TIDAK BISA DIBANDINGKAN ENTAH KENAPA...
            ///////////////
            Console.Write("Masukan deret angka(pemisah angka dengan spasi): ");
            string strderet = (Console.ReadLine());
            string[] arrderet = strderet.Split(' ');

            Array.Sort(arrderet);



            int[] intArrderet = Array.ConvertAll<string, int>(arrderet, int.Parse);


            //Finding the median
            double temp = 0;
            int median = 0;
            if (intArrderet.Length % 2 == 0)
            {
                median = (intArrderet.Length / 2);
                temp = (float)(intArrderet[median] + intArrderet[median - 1]) / 2;
            }
            else
            {
                median = (intArrderet.Length - 1) / 2;
                temp = intArrderet[median];
            }

            Console.WriteLine($"Median-nya adalah: {temp.ToString("n2")}");


            Console.ReadKey();
        }
    }
}
