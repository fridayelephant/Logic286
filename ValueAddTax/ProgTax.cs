using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanSoal5
{
    public class ProgTax
    {
        public ProgTax()
        {
            Console.WriteLine("Masukan nilai duit: ");
            double penghasilan = double.Parse(Console.ReadLine());
            HitungPajak(penghasilan);
        }

        private double HitungPajak(double penghasilan)
        {
            double pajak = 0;
            double temp;

            double taxable = penghasilan;

            if (taxable < 25000)
            {
                return pajak;
            }
            else
            {
                if (taxable > 25000)
                {
                    if (taxable >= 50000)
                    {
                    temp = 50000 * (double)0.05;
                    pajak += temp;
                    taxable -= 50000;

                        if (taxable >= 100000)
                        {
                            temp = 50000 * (double)0.1;
                            pajak += temp;
                            taxable -= 50000;

                            if (taxable > 100000)
                            {
                                if (taxable >= 200000)
                                {
                                    temp = 100000 * (double)0.15;
                                    pajak += temp;
                                    taxable -= 100000;

                                    if (taxable > 200000)
                                    {
                                        temp = taxable * (double)0.25;
                                        pajak += temp;
                                        taxable -= 200000;
                                    }
                                    else 
                                    {
                                        temp = taxable * (double)0.25;
                                        pajak += temp;
                                        taxable -= 200000;
                                    }
                                }
                                else
                                {
                                    temp = taxable * (double)0.15;
                                    pajak += temp;
                                }
                            }
                            else 
                            {
                                temp = taxable * (double)0.15;
                                pajak += temp;
                            }
                        }
                        else
                        {
                            temp = taxable * (double)0.1;
                            pajak += temp;
                        }
                    }
                    else
                    {
                        temp = taxable * (double)0.05;
                        pajak += temp;
                    }
                }
                return pajak;
            }
        }
    }
}
