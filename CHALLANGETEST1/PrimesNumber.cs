using System;
using System.Collections.Generic;
using System.Text;

namespace CHALLANGETEST1
{
    public class PrimesNumber
    {
        public PrimesNumber()
        {
            Console.WriteLine("=== Program Prima ===");
            Console.Write("Masukan Nilai N: ");
            int n = int.Parse(Console.ReadLine());

            CariPrima(n);
        }

        private void CariPrima(int n)
        {
            List<int> listPrimes = new List<int>();

            bool prima = true;
            while (listPrimes.Count < n)
            {
                if (listPrimes.Count >= 2)
                {
                    for (int i = 2; i <= listPrimes.Count; i++)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if ((i % j) == 0)
                            {
                                prima = false;
                                break;
                            }
                        }

                        if (prima)
                            Console.WriteLine("Bilangan " + i + " adalah bilangan prima");
                        prima = true;
                    }
                }
                else
                    Console.WriteLine("Tidak ada bilangan prima yang bisa dituliskan");
                Console.ReadLine();

            }

        }
    }
}


////PROGRAM BILANGAN PRIMA DENGAN BATAS N
//Console.WriteLine("=== Program Sederhana Bilangan Prima ===");
//Console.Write("Masukkan Batas Bilangan Prima : ");

//bool prima = true;
//int bilangan = int.Parse(Console.ReadLine());


//if (bilangan >= 2)
//{
//    for (int i = 2; i <= bilangan; i++)
//    {
//        for (int j = 2; j < i; j++)
//        {
//            if ((i % j) == 0)
//            {
//                prima = false;
//                break;
//            }
//        }

//        if (prima)
//            Console.WriteLine("Bilangan " + i + " adalah bilangan prima");
//        prima = true;
//    }
//}
//else
//    Console.WriteLine("Tidak ada bilangan prima yang bisa dituliskan");
//Console.ReadLine();




////CODE Ari Ashari Jaelani:
//Console.Clear();
//Console.Write("Number : ");
//int number = int.Parse(Console.ReadLine());
//bool prima = true;
//int count = 0;
//List<int> prime = new List<int>();
//for (int x = 2; x <= Int32.MaxValue; x++)
//{
//    int isPrime = 0;
//    for (int y = 1; y < x; y++)
//    {
//        if (x % y == 0)
//            isPrime++;

//        if (isPrime == 2) break;
//    }
//    if (isPrime != 2)
//    {
//        prime.Add(x);
//        Console.WriteLine($"Bilangan {x} adalah bilangan prima");
//        count++;

//    }
//    if (count == number)
//        break;
//    isPrime = 0;
//}
//Console.ReadKey();