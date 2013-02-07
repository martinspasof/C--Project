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
        
        int j = 0;       
        int k = rows * cols;
        int count = 0;

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++, count++)
        {           
            matrix[i, j] = count + 1;

            if (i == rows - 1 && j != cols - 1)
            {
                j++;
                i = -1;                
            }           
        }

        for (int a = 0; a < matrix.GetLength(0); a++)
        {
            for (int b = 0; b < matrix.GetLength(1); b++)
            {
                Console.Write("{0,3}", matrix[a,b] + " ");
            }
            Console.WriteLine();
        } 

    }
}
