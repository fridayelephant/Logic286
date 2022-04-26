using System;
using System.Collections.Generic;
using System.Text;

namespace Hari04
{
    public class TimeConversion
    {
        public TimeConversion()
        {
            Console.WriteLine("=== 12H AM/PM to Military Time Converstion");
            Console.Write("Masukan input jam [0-12]: ");
            string jam = Console.ReadLine();

            Console.Write("Masukan input menit [00-59]: ");
            string menit = Console.ReadLine();

            Console.Write("Masukan input detik [00-59]: ");
            string detik = Console.ReadLine();

            Console.WriteLine($"Input adalah: {jam}:{menit}:{detik}");

            Console.Write("Masukan format waktu [AM/PM]: ");
            string format = Console.ReadLine();


            if (format == "AM")
                Console.WriteLine($"Waktu yang anda masukan adalah: {jam}:{menit}:{detik} {format}");

            else if (format == "PM")
            {
                int jamInt = int.Parse(jam);
                int newjamInt = jamInt + 12;
                if (newjamInt == 24)
                    Console.WriteLine($"Waktu yang anda masukan adalah: 00:{menit}:{detik} {format}");
                else
                    Console.WriteLine($"Waktu yang anda masukan adalah: {jam}:{menit}:{detik} {format}");
            }
            else
                Console.WriteLine("Format Yang Anda Masukan Salah");
           
            Console.ReadKey();
        }
    }
}
