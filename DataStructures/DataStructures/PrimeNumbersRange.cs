using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeNumbersRange
    {     
        /// <summary>
        /// prints the prime numbers between 1 to 1000
        /// </summary>
        internal static void print()
        {
            long range = 1000;
            Console.WriteLine("Prime Numbers are:");
            if (range <= 1)
                Console.WriteLine("Not a Prime Number");
            else
            {
                for (int i = 1; i <= range; i++)
                {
                    int counter = 0;
                    for (int j = i; j >= 1; j--)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
