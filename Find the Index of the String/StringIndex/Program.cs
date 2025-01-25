// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        string S = "racecar";
        int result = Solution(S);
        Console.WriteLine(result);
    }

    /// <summary>
    /// </summary>
    /// <param name="S"></param>
    /// <returns></returns>

    static int Solution(string S)
    {
        int n = S.Length;
        
        for (int i = 0; i < n; i++)
        {
            string leftPart = S.Substring(0, i);    // Left of the character
            string rightPart = S.Substring(i + 1);  // Right of the character

            // Compare the left part with the reversed right part
            if (leftPart == string.Join("", rightPart.ToCharArray().Reverse()))
            {
                return i;
            }
        }
        return -1;
    }
}