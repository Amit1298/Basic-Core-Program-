using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Program
{
    class Quotient_and_Remainder
    {
        public void quotRem()
        {
            int dividend;
            int divisor;
            Console.WriteLine("Enter the Dividend : ");
            dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Divisor : ");
            divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);     //placeholder decliration
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
