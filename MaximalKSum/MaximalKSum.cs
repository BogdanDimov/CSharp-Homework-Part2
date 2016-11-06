using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int[] max = new int[k];

            for (int i = 0; i < k; i++)
            {
                max[i] = int.MinValue;
            }

            int input;

            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input > max.Min())
                {
                    max[Array.IndexOf(max, max.Min())] = input;
                }
            }

            int sum = 0;
            foreach (int value in max)
            {
                sum += value;
            }

            Console.WriteLine(sum);
        }
    }
}
