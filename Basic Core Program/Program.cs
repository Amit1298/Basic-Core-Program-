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
            Console.ReadLine();
        }
    }
}
