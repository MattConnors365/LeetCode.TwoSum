using System.Collections;

namespace LeetCode.TwoSum
{
    internal class On // Solutions with a time complexity of O(n)
    {
        public static int[] HashMapTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> HashMap = new Dictionary<int, int>(); // Initialize dictionary
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i]; // Complement == what sums up with nums[i] to target
                if (HashMap.ContainsKey(complement)) // If complement is a key in the dictionary
                {
                    return new int[] { HashMap[complement], i }; // Return the indices of the two numbers
                } else
                {
                    HashMap[nums[i]] = i; // Add the current number and its index to the dictionary
                } // Iteration over, start again with the next number (if solution not already found)
            }
            throw new Exception($"Could not find a TwoSum solution given the array {nums} and the target {target}");
        }
    }
}
