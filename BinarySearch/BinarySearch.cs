using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int value = int.Parse(Console.ReadLine());
            int low = 0;
            int high = n - 1;
            int mid, index = -1;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (a[mid] > value)
                {
                    high = mid - 1;
                }
                else if (a[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    index = mid; break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
