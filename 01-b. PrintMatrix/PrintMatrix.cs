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
                if (matrix[i, j] == 0)
                {
                    matrix[i, j] = count + 1;
                }

                if (i == rows - 1 && j != cols - 1)
                {
                    j++;
                    int copy = count;
                    if (j % 2 != 0)
                    {
                        for (int x = cols - 1; x >= 0; x--)
                        {
                            copy += 1;
                            matrix[x, j] = copy + 1;
                        }
                        i = 1;
                    }
                    else
                    {
                        count += 2;
                        i = -1;
                    }                    
                }
               
            }

            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    Console.Write("{0,3}", matrix[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }


