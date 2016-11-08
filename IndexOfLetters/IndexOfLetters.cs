using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsUpper(a[i]))
                {
                    Console.WriteLine(a[i] - 65); // letter is capital
                }
                else
                {
                    Console.WriteLine(a[i] - 97); // letter is small
                }

            }
        }
    }
}