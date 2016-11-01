using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long decimalNumber = int.Parse(Console.ReadLine());
            long remainder;
            string result = string.Empty;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}

//namespace DecimalToBinary
//{
//    class DecimalToBinary
//    {
//        static void Main()
//        {
//            long input = long.Parse(Console.ReadLine());
//            char[] charResult = new char[64]; // size is set to 64 because we will store long integers (Int64)
//            int count = 0; // number of leading zeros to be removed from the resulting string
//            bool flag = false; // indicates whether first bit with value 1 has been reached

//            long power;
//            for (int i = 63; i >= 0; i--)
//            {
//                power = (long)Math.Pow(2, i); // raise 2 to the power of i

//                if (input / power >= 1)
//                {
//                    charResult[63 - i] = '1';
//                    if (!flag)
//                    {
//                        flag = true;
//                        count = 63 - i;
//                    }

//                    input -= power;
//                }
//                else
//                {
//                    charResult[63 - i] = '0';
//                }
//            }

//            string stringResult = string.Join("", charResult);

//            // cut out leading zeros and print the result
//            Console.WriteLine(stringResult.Remove(0, count));
//        }
//    }
//}