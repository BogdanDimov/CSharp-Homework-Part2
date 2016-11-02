using System;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int direction = 1;
            int col = -1;
            int row = 0;
            int lenght = n;
            int count = 1;

            while (count <= n * n)
            {
                for (int j = 0; j < lenght; j++)
                {
                    col = col + direction;
                    matrix[row, col] = count;
                    count++;
                }
                lenght--;

                for (int k = 0; k < lenght; k++)
                {
                    row = row + direction;
                    matrix[row, col] = count;
                    count++;
                }
                direction = direction * (-1);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}