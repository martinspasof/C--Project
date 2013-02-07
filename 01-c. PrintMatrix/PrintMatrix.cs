using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PrintMatrix
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int j = 1;
        int k = 0;
        int a = 0;
        int b = 0;
        int[,] matrix = new int[rows, cols];

        for (int i = rows - 1; i >= 0; i--, j++)
        {
            matrix[i, k] = j;
            a = i;           
            int copy = k;
            
            while(i < rows)
            {
                matrix[i, copy] = j;
                i++;
                j++;
                copy++;
            }
            j = matrix[i - 1, copy - 1];
            i = a;                   
        }

        int start = matrix[rows - 1, cols - 1];

        for (j = 1; j < rows; j++)
        {
            matrix[b, j] = start + j;
            a = b;
            k = j;
            while (j < cols)
            {
                matrix[b, j] = start + j;
                b++;
                j++;
            }
            start = matrix[b - 1, j - 1] - k;
            b = a;
            j = k;            
        }

        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                Console.Write("{0,3}", matrix[x, y] + " ");
            }
            Console.WriteLine();
        }
    }
}

