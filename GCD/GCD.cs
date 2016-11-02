using System;

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = Math.Abs(int.Parse(input[0]));
            int B = Math.Abs(int.Parse(input[1]));

            int temp = A;

            while (A != 0 && B != 0)
            {
                if (A > B)
                {
                    temp = B;
                    B = A % B;
                    A = temp;
                }
                else
                {
                    temp = A;
                    A = B % A;
                    B = temp;
                }
            }

            Console.WriteLine(A == 0 ? B : A);
        }
    }
}
