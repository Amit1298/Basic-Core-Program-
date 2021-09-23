using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Program
{  
    class leapYear
    {
        public void printYear()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if ((Year % 4 == 0))
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
