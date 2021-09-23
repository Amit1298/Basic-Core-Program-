using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Program
{
    class checkOddEven
    {
        public void OddEven()
        {
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Check whether a number is even or odd :\n");  // \n is used for new line
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an even integer.\n", num1);                // placeholder calling
            else
                Console.WriteLine("{0} is an odd integer.\n", num1);
        }
    }
}
