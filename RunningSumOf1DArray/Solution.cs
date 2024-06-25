using System;
using System.Collections.Generic;
using System.Text;

namespace RunningSumOf1DArray
{
    public class Solution
    {
        public static int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;
        }
    }
}
