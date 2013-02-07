using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearch
{
    public static void Sort(int[] numbers, int count)
    {
        int number;

        for (int i = 1; i < count; i++)
        {
            for (int j = count - 1; j >= 1; j--)
            {
                if (numbers[j - 1] > numbers[j])
                {
                    number = numbers[j - 1];
                    numbers[j - 1] = numbers[j];
                    numbers[j] = number;
                }
            }
            
        }
    }
    static void Main()
    {
        Console.Write("Count: ");
        int count = int.Parse(Console.ReadLine());        
        int[] elements = new int[count];
        Console.Write("wanted integer: ");
        int wanted = int.Parse(Console.ReadLine());
        List<int> List = new List<int>();
        int index = 0;
        int middle = 0;
        int curr = 0;
        int start = 0;
        int end = elements.Length - 1;

        Console.WriteLine("Insert elements:");

        for (int i = 0; i < count; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }

        Sort(elements, count);
        
        while (start <= end)
        {
            middle = (start + end + 1) / 2;
            curr = elements[middle];

            if (curr == wanted)
            {
                if (curr <= wanted)
                {
                    List.Add(curr);
                }
                index = middle;
                break;
            }
            else if (curr < wanted)
            {
                if (curr <= wanted)
                {
                    List.Add(curr);
                }
                start = middle + 1;
            }
            else
            {                
                end = middle - 1;
            }
        }

        if (curr <= wanted)
        {
            Console.WriteLine("The given element is {0}.", List.Last());
        }
        else
        {
            Console.WriteLine("Not find the search number!");
        }      

    }
}