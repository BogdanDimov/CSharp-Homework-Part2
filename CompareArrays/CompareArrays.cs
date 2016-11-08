using System;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N], arr2 = new int[N];

            string s = "Equal";

            for (int i = 0; i < N; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    s = "Not equal";
                    break;
                }
            }

            Console.WriteLine(s);
        }
    }
}
