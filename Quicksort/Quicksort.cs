using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Quicksort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int idx = 0; idx < n; idx++)
            {
                a[idx] = int.Parse(Console.ReadLine());
            }

            int low = 0;
            int high = n - 1;

            int[] stack = new int[high - low + 1];

            int top = -1;

            stack[++top] = low;
            stack[++top] = high;

            while (top >= 0)
            {
                high = stack[top--];
                low = stack[top--];

                int partition;

                #region Partitioning

                int x = a[high];
                int i = low - 1;
                int temp;

                for (int j = low; j <= high - 1; j++)
                {
                    if (a[j] <= x)
                    {
                        i++;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

                temp = a[i + 1];
                a[i + 1] = a[high];
                a[high] = temp;

                partition = i + 1;
                #endregion

                if (partition - 1 > low)
                {
                    stack[++top] = low;
                    stack[++top] = partition - 1;
                }

                if (partition + 1 < high)
                {
                    stack[++top] = partition + 1;
                    stack[++top] = high;
                }
            }

            Console.WriteLine(string.Join("\n", a));
        }
    }
}
