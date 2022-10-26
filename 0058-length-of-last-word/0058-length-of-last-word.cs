public class Solution {
    public int LengthOfLastWord(string s) {
        var w = s.TrimEnd().Split();
            return w[w.Length - 1].Length;
    }
}