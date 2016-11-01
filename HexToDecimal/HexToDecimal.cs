using System;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            long output = 0;

            int temp = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                switch (charArray[charArray.Length - 1 - i])
                {
                    case 'A': temp = 10; break;
                    case 'B': temp = 11; break;
                    case 'C': temp = 12; break;
                    case 'D': temp = 13; break;
                    case 'E': temp = 14; break;
                    case 'F': temp = 15; break;
                    default: temp = -48 + (int)charArray[charArray.Length - 1 - i]; break; // -48 because of ASCII
                }

                output += temp * (long)Math.Pow(16, i);
            }

            Console.WriteLine(output);
        }
    }
}
