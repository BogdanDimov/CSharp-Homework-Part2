using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            bool[] a = new bool[n + 1];

            for (int i = 2; i < n + 1; i++)
            {
                a[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(n + 1); i++)
            {
                if (a[i])
                {
                    for (int j = i * i; j < n + 1; j += i)
                    {
                        a[j] = false;
                    }
                }
            }

            int maxPrime = 1;

            for (int i = 2; i < n + 1; i++)
            {
                if (a[i] == true)
                {
                    maxPrime = i;
                }
            }

            Console.WriteLine(maxPrime);
        }
    }
}
