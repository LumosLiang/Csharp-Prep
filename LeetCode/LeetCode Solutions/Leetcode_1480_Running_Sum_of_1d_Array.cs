namespace LeetCode
{
    public class Leetcode_1480_Running_Sum_of_1d_Array
    {
        public int[] RunningSum(int[] nums)
        {

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}