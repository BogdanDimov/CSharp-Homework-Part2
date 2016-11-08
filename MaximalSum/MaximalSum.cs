using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxsum, beginmax, endmax, sum; maxsum = beginmax = sum = 0; endmax = -1;

            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int k = i; k < n; k++)
                {
                    sum += arr[k];
                    if (sum > maxsum)
                    {
                        maxsum = sum;
                        beginmax = i;
                        endmax = k;
                    }
                }
            }

            Console.WriteLine(maxsum);
        }
    }
}