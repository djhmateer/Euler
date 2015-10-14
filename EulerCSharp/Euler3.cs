using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EulerCSharp
{
    public class Euler3
    {
        static void Main()
        {
            long number = 600851475143;
            var factors = GetPrimeFactors(number);
            Console.WriteLine(string.Join(",", factors.ToArray()) + " are the prime factors of " + 600851475143 + " and " + factors.LastOrDefault() + " is the largest.");
            Console.ReadLine();
        }

        public static List<long> GetPrimeFactors(long number)
        {
            var factors = new List<long>();

            //Once I’ve found a factor (eg 3) I divide by it, because it HAS to be prime,
            
            // number=15   
            // loop1: j=2              maxLoop=15  
            //        j=3  factorFound maxLoop=5
            //        j=4              maxLoop=5
            //        j=5  factorFound

            //otherwise there would be a factor before it which is prime which divides the factor.

            //So by that logic, each factor you come across will be prime…
            //as long as you divide the number you are looking for by the primes previously found.
            for (long j = 2; j <= number; j++)
            {
                if (number%j == 0)
                {
                    factors.Add(j);
                    number = number/j;
                }
            }
            return factors;
        }

        [Fact]
        public void X4_ShouldReturnOnly2()
        {
            var result = GetPrimeFactors(4);
            Assert.Equal(2, result[0]);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void X5_ShouldReturnOnly5AsTheOnlyPrimeFactorOfAPrimeIsItself()
        {
            var result = GetPrimeFactors(5);
            Assert.Equal(5, result[0]);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void X6()
        {
            var result = GetPrimeFactors(6);
            Assert.Equal(2, result[0]);
            Assert.Equal(3, result[1]);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void X8()
        {
            // this returns 2 and 4, which should just be 2
            var result = GetPrimeFactors(8);
            Assert.Equal(2, result[0]);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void X9()
        {
            var result = GetPrimeFactors(9);
            Assert.Equal(3, result[0]);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void X15()
        {
            var result = GetPrimeFactors(15);
            Assert.Equal(3, result[0]);
            Assert.Equal(5, result[1]);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void X21()
        {
            var result = GetPrimeFactors(21);
            Assert.Equal(3, result[0]);
            Assert.Equal(7, result[1]);
            Assert.Equal(2, result.Count);
        }


       

        [Fact]
        public void X90()
        {
            var result = GetPrimeFactors(90);
            Assert.Equal(2, result[0]);
            Assert.Equal(3, result[1]);
            Assert.Equal(5, result[2]);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void X147()
        {
            var result = GetPrimeFactors(147);
            Assert.Equal(3, result[0]);
            Assert.Equal(7, result[1]);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void X13195()
        {
            var result = GetPrimeFactors(13195);
            Assert.Equal(5, result[0]);
            Assert.Equal(7, result[1]);
            Assert.Equal(13, result[2]);
            Assert.Equal(29, result[3]);
            Assert.Equal(4, result.Count);
        }
    }
}
