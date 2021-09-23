using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Program
{
    class harmonicNumber
    {
        public void nthHarmonic(int n)
        {
            double i, s = 0.0;

            for (i = 1; i <= n; i++)
                s = s + 1 / i;

            Console.WriteLine((float)s);
        }
    }
}
