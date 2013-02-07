using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayofStrings
{
    static void Main()
    {
        String[] beers = {"Zagorka", "Ariana",
            "Shumensko","Astika", "Kamenitza", "Bolqrka",
            "Amstel"};
        string[] stack = new string[beers.Length];
        int[] copyArray = new int[beers.Length];
        int[] lengthOfString = new int[beers.Length];       
        int j = 0;
        int k = 0;
        int count = 0;

        for (int index = 0; index < beers.Length; index++)
        {
            lengthOfString[index] = beers[index].Length;            
        }

       
        Array.Copy(lengthOfString, copyArray, beers.Length);
        Array.Sort(copyArray);

        for (int i = 0; i < beers.Length; i++)
        {
            if (j == beers.Length)
            {
                j = 0;
            }
            while (copyArray[i] != lengthOfString[j])
            {
                if (j == k && j != 0)
                {
                    continue;
                }
                j++;
                if (j == beers.Length)
                {
                    j = 0;
                }
            }
            
            stack[i] = beers[j];
            k = j;
            j++;
        }

        foreach (var text in stack)
        {
            Console.WriteLine(text);
        }
                
    }
}