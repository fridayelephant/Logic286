using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    public class RDSum
    {
        public RDSum()
        {
            Console.WriteLine("Masukan nilai n: ");
            int num = int.Parse(Console.ReadLine());
            int result = sum_of_digit(num);
            Console.WriteLine("Sum of digits in " +
                               num + " is " + result);
        }

        static int sum_of_digit(int n)
        {
            if (n == 0)
                return 0;

            return (n % 10 + sum_of_digit(n / 10));
        }

    }
}
