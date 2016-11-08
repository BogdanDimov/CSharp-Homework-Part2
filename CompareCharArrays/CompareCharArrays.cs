using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string s1 = Console.ReadLine(); string s2 = Console.ReadLine();

            string result = "=";

            int length = Math.Min(s1.Length, s2.Length);

            for (int i = 0; i < length; i++)
            {
                if (s1[i] < s2[i])
                {
                    result = "<"; break;
                }
                else if (s1[i] > s2[i])
                {
                    result = ">"; break;
                }
                else
                {
                    if (s1.Length > s2.Length)
                    {
                        result = ">";
                    }
                    else if (s1.Length < s2.Length)
                    {
                        result = "<";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}