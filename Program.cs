using System;
using System.Collections.Generic;

class Program
{
    static List<int> IndexOfCapitals(string inputString)
    {
        List<int> indices = new List<int>();
        for (int i = 0; i < inputString.Length; i++)
        {
            if (char.IsUpper(inputString[i]))
            {
                indices.Add(i);
            }
        }
        return indices;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        List<int> result = IndexOfCapitals(inputString);

        Console.Write("Indices of capital letters: ");
        if (result.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            Console.WriteLine(string.Join(", ", result));
        }
    }
}