using System;

namespace Basic_Core_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Flip Coin");
            //Variables
            int count = 0;
            float tails = 0;
            float head = 0;
            while (count <20)
            {
                Random random = new Random();
                int result = random.Next(0, 2);
                if (result == 1)
                {
                    Console.WriteLine("Tails");
                    tails++;
                    count++;
                }
                else
                {
                    Console.WriteLine("Head");
                    head++;
                    count++;
                }
            }
            Console.WriteLine("Heads = " + head + " Tails = " + tails + " Counts = " + count);
            Console.WriteLine("Heads = " + (head * 100f/ count)+"%" + " Tails = " + tails * 100f/ count +"%");
            leapYear lpYear = new leapYear();
            Console.ReadLine();
            lpYear.printYear();
            Console.ReadLine();

            PowerOfTwo power = new PowerOfTwo();
            power.powerTwo();
            Console.ReadLine();

            harmonicNumber number = new harmonicNumber();
            number.nthHarmonic(2);
            Console.ReadLine();

            primeFactors primeNum = new primeFactors();
            primeNum.Prime();
            Console.ReadLine();

            Quotient_and_Remainder Quotant = new Quotient_and_Remainder();
            Quotant.quotRem();
            Console.ReadLine();

            SwapNumber TwoNumber = new SwapNumber();
            TwoNumber.TwoSwap();
            Console.ReadLine();

            checkOddEven checkNumber = new checkOddEven();
            checkNumber.OddEven();
            Console.ReadLine();
        }
    }
}
