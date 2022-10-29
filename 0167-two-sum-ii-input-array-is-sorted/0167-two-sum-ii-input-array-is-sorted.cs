public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
           int fr=0,end=numbers.Length-1;
            while (numbers[fr] + numbers[end] != target)
            {
                if (numbers[fr] + numbers[end] > target)
                {
                    end--;
                }
                else fr++;
            }
            return new int[] { fr + 1, end + 1 }; 
    }
}