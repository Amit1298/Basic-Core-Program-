using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Program
{
    class Alphabet
    {
        public void checkVowal()
        {
            Console.WriteLine("Write the Alphabet");
            Console.WriteLine("------------------------------------------------------------");
            char ch;
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch(ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowal");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowal");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowal");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowal");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowal");
                    break;
                default:
                    Console.WriteLine("The Alphabet is Consonant");
                    break;
            }
            Console.ReadLine();
        }
    }
}
