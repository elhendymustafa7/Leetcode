public class Solution {
    public bool IsPalindrome(int x) {
         int Reverse = 0;
            int number =x;
            while (number > 0)
            {
                int remainder = number % 10;
                Reverse = (Reverse * 10) + remainder;
                number = number / 10;
            }
            if (Reverse == x) return true;
            return false;
    }
}