public class Solution {
           public int[] Shuffle(int[] nums, int n) 
           {
               int[] newArr = new int [nums.Length];
            int j = 0;
            int k = n;
            for (int i = 0; i < nums.Length; i+=2)
            {
               
                while(j<n)
                {
                    newArr[i] = nums[j];
                    break;
                }
                j++;
               
            }
            for (int i = 1; i < nums.Length; i += 2)
            {
                while (k < nums.Length)
                {
                    newArr[i] = nums[k];
                    break;
                }
                k++;
            }
            return newArr;
            
           }
}