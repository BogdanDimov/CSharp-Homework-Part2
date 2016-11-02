using System;

namespace TrailingZeroInN_
{
    class Program
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());

            uint count = 0; // number of trailing zeros

            for (uint i = 5; i <= N; i *= 5)
            {
                count += N / i;
            }

            Console.WriteLine(count);
        }
    }
}
