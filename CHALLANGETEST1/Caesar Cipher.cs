using System;
using System.Collections.Generic;
using System.Text;

namespace CHALLANGETEST1
{
    public class Caesar_Cipher
    {
        public Caesar_Cipher()
        {
            //// CARA 1
            //char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            ////Input parameter awal
            //Console.WriteLine("Masukan kata yang ingin di enkripsi: ");
            //string pesan = Console.ReadLine();

            //int key = 0;

            //// Mengantisipasi kesalahan input longkap
            //try
            //{
            //    Console.WriteLine("Masukan jumlah longkap: ");
            //    key = Convert.ToInt32(Console.ReadLine());
            //}

            //catch (Exception exp)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Jumlah longkap harus interger!");
            //    Console.WriteLine(exp.StackTrace);
            //}
            //char[] pesanRahasia = pesan.ToCharArray();

            //char[] pesanTerenrkipsi = new char[pesanRahasia.Length];

            //// fungsi decoder
            //for (int i = 0; i < pesanRahasia.Length; i++)
            //{
            //    char huruf = pesanRahasia[i];
            //    int posisihuruf = Array.IndexOf(alphabet, huruf);
            //    int newposisi = (posisihuruf + key) % 26;   // mau buat dekoder huruf menjadi linkaran
            //    char pesanDecoder = alphabet[newposisi];
            //    pesanTerenrkipsi[i] = pesanDecoder;
            //}

            //string pesanTerdecoder = String.Join("", pesanTerenrkipsi);

            //Console.WriteLine($"Pesanmu telah terenkripsi menjadi: {pesanTerdecoder}");


            // CARA 2
            // Pembuatan library untuk huruf terenkripsi
            string alpLower = "abcdefghijklmnopqrstuvwxyz";
            string alpUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            //Console.WriteLine("Masukan banyaknya kata: ");
            //int banyakKata = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan banyaknya shift yang dilakukan: ");
            int move = int.Parse(Console.ReadLine());

            string result = "";
            Console.WriteLine("Masukan kata yang dingiinkan: ");
            string input = Console.ReadLine();

            //// Validasi Library
            //if (banyakKata < 26)
            //    banyakKata = banyakKata/26;
            //else
            //    banyakKata = banyakKata / 1;

            // Validasi Inputan
            for (int i = 0; i < input.Length; i++)
                {
                    int posLow = alpLower.IndexOf(input[i]);
                    int posUpper = alpUpper.IndexOf(input[i]);

                    if (posLow == -1 && posUpper == -1)         // buat tanda baca dan angka
                        result += input[i];
                    else if (posLow > -1)                       // buat huruf kecil
                        result += alpUpper[posUpper + move];
                    else if (posUpper > -1)                     // buat huruf besar
                        result += alpUpper[posUpper + move];
                }

            Console.WriteLine(result);
            Console.WriteLine("Press any key");
            Console.ReadKey();
         
        }
    }
}
