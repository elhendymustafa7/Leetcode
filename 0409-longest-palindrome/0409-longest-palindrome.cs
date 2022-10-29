public class Solution {
    public int LongestPalindrome(string s) {
         var even = s.GroupBy(c => c).Select(g => g.Count() & ~1).Sum();
        return even < s.Length ? even + 1 : even;
    }
}