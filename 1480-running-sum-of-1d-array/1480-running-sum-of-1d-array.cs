public class Solution {
    public int[] RunningSum(int[] nums) {
         int sum = 0;
            var ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                ans[i] = sum ;
            }
            return ans;
    }
}