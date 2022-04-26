using System;

namespace TimeConversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 12H AM/PM to Military Time Converstion");
            Console.Write("Masukan format waktu [hh:mm:ss AM/PM]: ");
            string waktu = Console.ReadLine();

            string strHH = waktu.Substring(0, 2);
            string strMM = waktu.Substring(3, 2);
            string strSS = waktu.Substring(6, 2);
            string format = waktu.Substring(9, 2);

            int strJamToInt = int.Parse(strHH);

            if (format == "PM")
            {
                int convJam = strJamToInt + 12;
                Console.WriteLine($"{0}:{1}:{2}", convJam, strMM, strSS);
            }
            else if (format == "AM")
            {
                Console.WriteLine($"{0}:{1}:{2}", strHH, strMM, strSS);
            }
            else
            {
                Console.WriteLine("Format Yang Anda Masukan Salah");
            }
            Console.ReadKey();
        }
    }
}
