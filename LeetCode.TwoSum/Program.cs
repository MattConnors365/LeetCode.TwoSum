using System;

namespace LeetCode.TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            DateTime start1 = DateTime.Now;
            int[] result1 = OnSquared.SimpleTwoSum(nums, target);
            Console.WriteLine($"[O(n^2)] Indices of the two numbers that add up to {target} are: {{{result1[0]}, {result1[1]}}}");
            DateTime end1 = DateTime.Now;
            TimeSpan elapsed1 = end1 - start1;
            Console.WriteLine($"Elapsed time: {elapsed1.TotalMilliseconds} ms");

            DateTime start2 = DateTime.Now;
            int[] result2 = On.HashMapTwoSum(nums, target);
            Console.WriteLine($"[O(n)] Indices of the two numbers that add up to {target} are: {{{result2[0]}, {result2[1]}}}");
            DateTime end2 = DateTime.Now;
            TimeSpan elapsed2 = end2 - start2;
            Console.WriteLine($"Elapsed time: {elapsed2.TotalMilliseconds} ms");
        }
    }
}
