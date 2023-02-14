using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNum
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var last = nums[nums.Count - 1];
            nums.RemoveAll(x=>x==last);
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
