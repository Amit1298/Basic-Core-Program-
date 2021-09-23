using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Program
{
    class PowerOfTwo
    {
        public void powerTwo()
        {
            Console.WriteLine("Enter the value of N : ");
            int n = Convert.ToInt32(Console.ReadLine());
          //  for (int N = 0; N <= n; N++)
            {
                //Console.WriteLine("2"+"*"+N+"="+N*2);
                double pow_t = Math.Pow(2, n);
                Console.WriteLine(pow_t);
                if ((pow_t % 4 == 0))
                {
                    Console.WriteLine("This Year is a Leap Year");
                }
                else
                {
                    Console.WriteLine("This Year is Not a Leap Year");
                }
            }
        }
    }
}
