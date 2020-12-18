using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Contains a method to find the maximum number in a list</summary>
    public class Operations
    {
        /// <summary>Finds the maximum in a list on integers</summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }

            int max = nums[0];
            foreach (int element in nums)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }
    }
}
