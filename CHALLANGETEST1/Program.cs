using System;

namespace CHALLANGETEST1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Challange01();
        }

        public static void Challange01()
        {
            Console.Clear();
            Console.WriteLine("== Soal Challange ==");

            Console.Write("masukan angka pertama : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("masukan angka kedua: ");
            int n2 = int.Parse(Console.ReadLine());

            //output hasil nantinya
            int hasil = n1 + n2;
            Console.WriteLine("====== === === == ==== ");
            Console.WriteLine("Hasil: {0}", hasil);
            Console.WriteLine("Penjumlahan kedua bilangan n1 dan n2 adalah : {0} + {1} = {2}", n1, n2, hasil);
        }

    }
}
