using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoSum
{
    internal class OnSquared // Solutions with a time complexity of O(n^2)
    {
        public static int[] SimpleTwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }
            throw new Exception($"Could not find a TwoSum solution given the array {nums} and the target {target}");
        }
    }
}
