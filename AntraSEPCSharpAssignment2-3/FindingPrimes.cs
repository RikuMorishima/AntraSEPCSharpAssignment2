using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraSEPCSharpAssignment2_3
{
    internal class FindingPrimes
    {
        static List<int> primes = new List<int>();
        public static int[] FindPrimesInRange(int startNum,int endNum)
        {
            if (primes.Count==0)
            {
                primes.Add(2);
            }
            List<int> primesInRange = new List<int>();
            for (int i = startNum; i < endNum;++i)
            {
                // Check boundaries to check whether we need to add to the list of primes
                int largestPrime=primes[primes.Count - 1] + 1;
                while (largestPrime < endNum)
                {
                    bool isPrime = true;
                    for (int j = largestPrime; --j > 1;)
                    {
                        // modulus equalling 0 means that it is divisible
                        if (largestPrime % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        primes.Add(largestPrime);
                    }
                    ++largestPrime;
                }

                // check if there is a prime in the list
                if (primes.Contains(i))
                {
                    primesInRange.Add(i);
                }
            }
            return primesInRange.ToArray();
        }
    }
}
