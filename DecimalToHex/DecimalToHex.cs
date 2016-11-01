using System;

namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            long input, remainder;
            string result, temp;
            result = temp = string.Empty;

            input = long.Parse(Console.ReadLine());

            while (input > 0)
            {
                remainder = input % 16;

                if (remainder < 10)
                    result += remainder;
                else
                {
                    switch (remainder)
                    {
                        case 10: temp = "A"; break;
                        case 11: temp = "B"; break;
                        case 12: temp = "C"; break;
                        case 13: temp = "D"; break;
                        case 14: temp = "E"; break;
                        case 15: temp = "F"; break;
                    }

                    result += temp;
                }

                input /= 16;
            }

            char[] charArray = new char[result.Length];

            for (int i = 0; i < result.Length; i++)
            {
                charArray[i] = result[result.Length - 1 - i]; // reverse the result string and copy to charArray
            }

            Console.WriteLine(string.Join("", charArray));
        }
    }
}
