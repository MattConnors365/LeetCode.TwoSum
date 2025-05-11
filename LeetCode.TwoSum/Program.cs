namespace LeetCode.TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            
            int[] result = OnSquared.SimpleTwoSum(nums, target);
            Console.WriteLine($"Indices of the two numbers that add up to {target} are: {{{result[0]}, {result[1]}}}");
        }
    }
}
