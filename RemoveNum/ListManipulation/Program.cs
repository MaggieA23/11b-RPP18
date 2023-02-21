using System;
using System.Collections.Generic;
using System.Linq;


namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command.ToLower()=="print")
                {
                   
                    break;
                }
                int index = 0;
                switch (command)
                {
                    case "add": index = int.Parse(input[1]);
                        var element = int.Parse(input[2]);
                        nums.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(input[1]);
                        for (int i =  input.Length-1; i > 1; i--)
                        {
                            element = int.Parse(input[1]);
                            nums.Insert(index, element);
                        }
                        break;
                    case "contains":
                        break;
                    case "remove":
                        break;
                    case "shift":
                        break;
                    case "sumPairs":
                        break;
                }
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
