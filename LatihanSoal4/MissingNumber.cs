using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal4
{
    public class MissingNumber
    {
        public MissingNumber()
        {
            Console.Clear();
            Console.WriteLine("=== Missing The Number ===");

            // Inputan Deret Pertama
            Console.WriteLine("Input Deret Pertama: ");
            string[] arrDeret1 = Console.ReadLine().Split(' ');     //tiap inputan dipisahkan dengan '(spasi)'
            List<string> listDeret1 = new List<string>();           //membuat wadah list baru bernama listDeret1
            listDeret1.AddRange(arrDeret1);                         //menambahkan item arrDeret1 pada listDeret1


            // Inputan Deret Kedua
            Console.WriteLine("Input Deret Kedua: ");
            string[] arrDeret2 = Console.ReadLine().Split(' ');
            List<string> listDeret2 = new List<string>();
            listDeret2.AddRange(arrDeret2);
            
            // Nested Looping untuk meng-Eliminasi angka yang sama pada listDeret1 & listDeret2
            // Fungsinya agar deret berapapun yang tersisia (tidak ter-Eliminasi) nantinya yang akan ditampilkan sebagai "Missing Number"

            for (int i = 0; i < listDeret1.Count; i++)    // Berarti melooping sebanyak "listDeret1" terhitung (isinya berapa)
            {
                for (int j = 0; j < listDeret2.Count; j++)  // Berarti melooping sebanyak "listDeret2" terhitung, sepanjang i (maksudnya looping i(1) sebanyak j dulu
                                                            // jadinya = i(1) & j=1 ==> i(1) & j(2) ==> .... i(1) & j(count) ||| Lalu i(2) & j=1 .... i(2) & j(count)|| dst 
                {
                    if (listDeret1[i] == listDeret2[j])
                    {
                        // Eliminasi
                        listDeret1.RemoveAt(i);
                        listDeret2.RemoveAt(j);
                        i--;
                        break;
                    }
                }
            }

            //Pembuatan wadah baru untuk list yang nantinya disort
            List<string> listJoin = new List<string>();
            
            //cara join ke-1
            foreach (string str in listDeret1)
            {
                listJoin.Add(str);
            }
            //cara join ke-2
            listDeret2.ForEach(item => listJoin.Add(item));

            listJoin.Sort();   //Sorting list dari "listJoin"
            listJoin.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
