using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a, b; a = b = new int[n];

            for (int id = 0; id < n; id++)
            {
                a[id] = int.Parse(Console.ReadLine()); ;
            }

            int i, j;
            int iMiddle = n / 2;
            i = 0; j = iMiddle;

            for (int k = 0; k < n; k++)
            {
                if (k < iMiddle && (j >= n || a[i] <= a[j]))
                {
                    b[k] = a[i];
                    i++;
                }
                else
                {
                    b[k] = a[j];
                    j++;
                }
            }

            Console.WriteLine(string.Join("\n", b));
        }
    }
}
