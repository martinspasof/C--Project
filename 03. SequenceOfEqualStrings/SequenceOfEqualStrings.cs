using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceOfEqualStrings
{
    public static void Print(int count, string text)
    {
        while (count > 0)
        {
            Console.Write(text + " ");
            count--;
        }
        Console.WriteLine();
    }
    static void Main()
    {
        
         /*string[,] matrix = 
        {
          {"s", "qq", "s"},
          {"pp", "pp", "s"},
          {"pp", "qq", "s"} 
        }; 
        */ 
       string[,] matrix = 
        {
          {"ha", "fifi", "ho", "hi"},
          {"fo", "ha", "hi", "xx"},
          {"xxx", "ho", "ha", "x"} 
        };        
        
        int a = 0;
        int b = 0;
        int count = 1;
        int maxCount = int.MinValue;
        int lengthX = matrix.GetLength(0);
        int lengthY = matrix.GetLength(1);

        for (int i = 0; i < lengthY - 1; i++)
        {
            for (int j = 0; j < lengthX; j++)
            {
                for (int k = i; k < lengthY - 1; k++)
                {
                    for (int m = j; m < lengthX; m++)
                    {
                        if (m == lengthX - 1)
                        {
                            break;
                        }
                        if(matrix[k, m] == matrix[k, m + 1])
                        {
                            count++;                   
                        }

                        else
                        {
                            break;
                        }

                        if (maxCount < count && count > 2)
                        {
                            maxCount = count;
                            Print(count, matrix[k, m]);
                        }
                    }

                    count = 1;

                    for (int n = i; n < lengthX - 1; n++)
                    {
                        if (matrix[n, j] == matrix[n + 1, j])
                        {
                            count++;
                        }

                        else
                        {
                            break;
                        }

                        if (maxCount < count && count > 2)
                        {
                            maxCount = count;
                            Print(count, matrix[n, j]);
                        }
                    }

                    count = 1;
                    b = j;
                    for (a = i; a < lengthX - 1; a++, b++)
                    {
                        if (b == lengthX - 1)
                        {
                            break;
                        }
                        if (matrix[a, b] == matrix[a + 1, b + 1])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }

                        if (maxCount < count && count > 2)
                        {
                            maxCount = count;
                            Print(count, matrix[a, b]);
                        }
                    }
                    count = 1;
                }
            }
        }

    }
}