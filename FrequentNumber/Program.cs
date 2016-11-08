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

            int number = arr[0], maxFrequency = 0, currentFrequency = 1;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentFrequency++;

                        if (currentFrequency > maxFrequency)
                        {
                            maxFrequency = currentFrequency;
                            number = arr[i];
                        }
                    }
                }

                currentFrequency = 0;
            }

            Console.WriteLine("{0} ({1} times)", number, maxFrequency);
        }
    }
}