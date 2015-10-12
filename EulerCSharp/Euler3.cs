using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerCSharp
{
    class Euler3
    {
        static void Main()
        {
            long number = 600851475143;
            var factors = new List<long>();

            for (long j = 2; j <= number; j++)
            {
                if (number % j == 0)
                {
                    factors.Add(j);
                    // Interesting strategy - like it!!!
                    number = number / j;
                    Console.WriteLine(j);
                }
            }


            Console.WriteLine(string.Join(",", factors.ToArray()) + " are the prime factors of " + 600851475143 + " and " + factors.LastOrDefault() + " is the largest.");
            Console.ReadLine();
        }
    }
}
