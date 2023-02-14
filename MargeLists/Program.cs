using System;
using System.Collections.Generic;
using System.Linq;


namespace MargeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            List<string> result = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries).ToList();
            result.Reverse();
            for (int i = 0; i < result.Count; i++)
            {
                int[] temp = result[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    input.Add(temp[j]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
