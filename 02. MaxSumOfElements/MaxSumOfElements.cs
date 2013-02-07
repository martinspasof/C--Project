using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSumOfElements
{
    static void Main()
    {
        int[,] matrix = 
        {
          {7, 1, 3, 3, 2, 1},
          {1, 3, 9, 8, 5, 6},
          {4, 6, 7, 9, 1, 0} 
        };

        int bestSum = int.MinValue;
        int sum = 0;
        int rows = 3;
        int cols = 3;

        for (int row = 0; row < matrix.GetLength(0) - rows + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - cols + 1; col++)
            {
                for (int i = row; i < row + rows; i++)
                {
                    for (int j = col; j < col + cols; j++)
                    {
                        sum += matrix[i, j];
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                        }
                    }
                }
                sum = 0;
            }          
            
        }

        Console.WriteLine(bestSum);
    }
}