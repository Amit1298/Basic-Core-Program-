using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Program
{
    class primeFactors
    {
        public void Prime()
        {
            int a, b;
            Console.WriteLine("Enter the Number : ");
            a = int.Parse(Console.ReadLine());
            for  (b = 1; b <= a; b++)
            {
                if (a%b == 0)
                {
                    Console.WriteLine(b+" is factor of "+a);
                }
            }
        }
    }
}
