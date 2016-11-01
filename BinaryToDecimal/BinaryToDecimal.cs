using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            int result = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[charArray.Length - i - 1] == '1')
                {
                    // calculate 2 to the power of i and add it to result
                    result += 1 << i;
                }
            }

            //for (int i = charArray.Length - 1; i >= 0; i--)
            //{
            //    if (charArray[i] == '1')
            //    {
            //        result += 1 << charArray.Length - 1 - i;
            //    }
            //}

            Console.WriteLine(result);
        }
    }
}
