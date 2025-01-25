// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 4, 10, 5, 4, 2, 10 };

        int result = FindFirstUniqueNumber(array);

        if (result != -1)
        {
            Console.WriteLine($"The first unique number {result}");
        }
        else
        {
            Console.WriteLine("No unique number found.");
        }
    }

    /// <summary>
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    
    static int FindFirstUniqueNumber(int[] array)
    {
        var unique = array.GroupBy(x => x)           
                          .Where(g => g.Count() == 1) 
                          .Select(g => g.Key)         
                          .FirstOrDefault();          

        return unique == 0 ? -1 : unique; 
    }
}