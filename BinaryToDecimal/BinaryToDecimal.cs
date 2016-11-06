using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[input.Length - i - 1] == '1')
                {
                    // calculate 2 to the power of i and add it to result
                    result += 1 << i;
                }
            }

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    if (input[i] == '1')
            //    {
            //        result += 1 << input.Length - 1 - i;
            //    }
            //}

            Console.WriteLine(result);
        }
    }
}