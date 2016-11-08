using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int count = 1;
            int temp = 1;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    temp++;
                }
                else
                {
                    temp = 1;
                }

                if (temp > count)
                {
                    count = temp;
                }
            }

            Console.WriteLine(count);
        }
    }
}
